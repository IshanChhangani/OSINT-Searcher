
namespace OSINT_SEARCHER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDDG = new System.Windows.Forms.Button();
            this.PanelSearchEngine = new System.Windows.Forms.Panel();
            this.btnStartPage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSearchEngine = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelVideoStreaming = new System.Windows.Forms.Panel();
            this.btnDailyMotion = new System.Windows.Forms.Button();
            this.btnVimeo = new System.Windows.Forms.Button();
            this.btnYoutubeMobile = new System.Windows.Forms.Button();
            this.btnYoutube = new System.Windows.Forms.Button();
            this.btnVideoStreaming = new System.Windows.Forms.Button();
            this.PanelStudies = new System.Windows.Forms.Panel();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.btnWolframAlfa = new System.Windows.Forms.Button();
            this.btnWikipedia = new System.Windows.Forms.Button();
            this.btnStudies = new System.Windows.Forms.Button();
            this.PanelSearchEngine.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelVideoStreaming.SuspendLayout();
            this.PanelStudies.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGoogle.Location = new System.Drawing.Point(0, 0);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(344, 30);
            this.btnGoogle.TabIndex = 1;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDDG
            // 
            this.btnDDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDDG.Location = new System.Drawing.Point(0, 30);
            this.btnDDG.Name = "btnDDG";
            this.btnDDG.Size = new System.Drawing.Size(344, 33);
            this.btnDDG.TabIndex = 3;
            this.btnDDG.Text = "duckduckgo";
            this.btnDDG.UseVisualStyleBackColor = true;
            this.btnDDG.Click += new System.EventHandler(this.button2_Click);
            // 
            // PanelSearchEngine
            // 
            this.PanelSearchEngine.Controls.Add(this.btnStartPage);
            this.PanelSearchEngine.Controls.Add(this.button4);
            this.PanelSearchEngine.Controls.Add(this.btnDDG);
            this.PanelSearchEngine.Controls.Add(this.btnGoogle);
            this.PanelSearchEngine.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchEngine.Location = new System.Drawing.Point(0, 36);
            this.PanelSearchEngine.Name = "PanelSearchEngine";
            this.PanelSearchEngine.Size = new System.Drawing.Size(344, 131);
            this.PanelSearchEngine.TabIndex = 4;
            this.PanelSearchEngine.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSearchEngine_Paint);
            // 
            // btnStartPage
            // 
            this.btnStartPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartPage.Location = new System.Drawing.Point(0, 98);
            this.btnStartPage.Name = "btnStartPage";
            this.btnStartPage.Size = new System.Drawing.Size(344, 33);
            this.btnStartPage.TabIndex = 5;
            this.btnStartPage.Text = "StartPage";
            this.btnStartPage.UseVisualStyleBackColor = true;
            this.btnStartPage.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(344, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Bing";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSearchEngine
            // 
            this.btnSearchEngine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchEngine.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEngine.Location = new System.Drawing.Point(0, 0);
            this.btnSearchEngine.Name = "btnSearchEngine";
            this.btnSearchEngine.Size = new System.Drawing.Size(344, 36);
            this.btnSearchEngine.TabIndex = 5;
            this.btnSearchEngine.Text = "Search Engines";
            this.btnSearchEngine.UseVisualStyleBackColor = true;
            this.btnSearchEngine.Click += new System.EventHandler(this.button3_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(433, 98);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(200, 36);
            this.button11.TabIndex = 9;
            this.button11.Text = "People Search";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Location = new System.Drawing.Point(433, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 132);
            this.panel2.TabIndex = 8;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 97);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(200, 36);
            this.button12.TabIndex = 5;
            this.button12.Text = "StartPage";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 64);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(200, 36);
            this.button13.TabIndex = 4;
            this.button13.Text = "Bing";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(0, 31);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(200, 36);
            this.button14.TabIndex = 3;
            this.button14.Text = "duckduckgo";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(0, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(200, 30);
            this.button15.TabIndex = 1;
            this.button15.Text = "Google";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(639, 288);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(200, 36);
            this.button21.TabIndex = 19;
            this.button21.Text = "Google";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button41);
            this.panel4.Controls.Add(this.button22);
            this.panel4.Controls.Add(this.button23);
            this.panel4.Controls.Add(this.button24);
            this.panel4.Controls.Add(this.button25);
            this.panel4.Location = new System.Drawing.Point(639, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 175);
            this.panel4.TabIndex = 18;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(0, 31);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(200, 36);
            this.button22.TabIndex = 5;
            this.button22.Text = "signed out google search";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(0, 97);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(200, 36);
            this.button23.TabIndex = 4;
            this.button23.Text = "Drive";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(0, 64);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(200, 36);
            this.button24.TabIndex = 3;
            this.button24.Text = "Youtube";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(0, 3);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(200, 30);
            this.button25.TabIndex = 1;
            this.button25.Text = "Google search";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(433, 288);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(200, 36);
            this.button26.TabIndex = 17;
            this.button26.Text = "Others";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button27);
            this.panel5.Controls.Add(this.button28);
            this.panel5.Controls.Add(this.button29);
            this.panel5.Controls.Add(this.button30);
            this.panel5.Location = new System.Drawing.Point(433, 321);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 132);
            this.panel5.TabIndex = 16;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(0, 97);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(200, 36);
            this.button27.TabIndex = 5;
            this.button27.Text = "StartPage";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(0, 64);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(200, 36);
            this.button28.TabIndex = 4;
            this.button28.Text = "Bing";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(0, 31);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(200, 36);
            this.button29.TabIndex = 3;
            this.button29.Text = "duckduckgo";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(0, 3);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(200, 30);
            this.button30.TabIndex = 1;
            this.button30.Text = "Google";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(0, 127);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(200, 36);
            this.button41.TabIndex = 6;
            this.button41.Text = "google Images";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelStudies);
            this.panel1.Controls.Add(this.btnStudies);
            this.panel1.Controls.Add(this.PanelVideoStreaming);
            this.panel1.Controls.Add(this.btnVideoStreaming);
            this.panel1.Controls.Add(this.PanelSearchEngine);
            this.panel1.Controls.Add(this.btnSearchEngine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 505);
            this.panel1.TabIndex = 20;
            // 
            // PanelVideoStreaming
            // 
            this.PanelVideoStreaming.Controls.Add(this.btnDailyMotion);
            this.PanelVideoStreaming.Controls.Add(this.btnVimeo);
            this.PanelVideoStreaming.Controls.Add(this.btnYoutubeMobile);
            this.PanelVideoStreaming.Controls.Add(this.btnYoutube);
            this.PanelVideoStreaming.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelVideoStreaming.Location = new System.Drawing.Point(0, 203);
            this.PanelVideoStreaming.Name = "PanelVideoStreaming";
            this.PanelVideoStreaming.Size = new System.Drawing.Size(344, 131);
            this.PanelVideoStreaming.TabIndex = 6;
            // 
            // btnDailyMotion
            // 
            this.btnDailyMotion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDailyMotion.Location = new System.Drawing.Point(0, 98);
            this.btnDailyMotion.Name = "btnDailyMotion";
            this.btnDailyMotion.Size = new System.Drawing.Size(344, 30);
            this.btnDailyMotion.TabIndex = 5;
            this.btnDailyMotion.Text = "Daily Motion";
            this.btnDailyMotion.UseVisualStyleBackColor = true;
            this.btnDailyMotion.Click += new System.EventHandler(this.btnDailyMotion_Click);
            // 
            // btnVimeo
            // 
            this.btnVimeo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVimeo.Location = new System.Drawing.Point(0, 63);
            this.btnVimeo.Name = "btnVimeo";
            this.btnVimeo.Size = new System.Drawing.Size(344, 35);
            this.btnVimeo.TabIndex = 4;
            this.btnVimeo.Text = "Vimeo";
            this.btnVimeo.UseVisualStyleBackColor = true;
            this.btnVimeo.Click += new System.EventHandler(this.btnVimeo_Click);
            // 
            // btnYoutubeMobile
            // 
            this.btnYoutubeMobile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYoutubeMobile.Location = new System.Drawing.Point(0, 30);
            this.btnYoutubeMobile.Name = "btnYoutubeMobile";
            this.btnYoutubeMobile.Size = new System.Drawing.Size(344, 33);
            this.btnYoutubeMobile.TabIndex = 3;
            this.btnYoutubeMobile.Text = "Youtube Mobile";
            this.btnYoutubeMobile.UseVisualStyleBackColor = true;
            this.btnYoutubeMobile.Click += new System.EventHandler(this.btnYoutubeMobile_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYoutube.Location = new System.Drawing.Point(0, 0);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(344, 30);
            this.btnYoutube.TabIndex = 1;
            this.btnYoutube.Text = "Youtube";
            this.btnYoutube.UseVisualStyleBackColor = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnVideoStreaming
            // 
            this.btnVideoStreaming.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVideoStreaming.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoStreaming.Location = new System.Drawing.Point(0, 167);
            this.btnVideoStreaming.Name = "btnVideoStreaming";
            this.btnVideoStreaming.Size = new System.Drawing.Size(344, 36);
            this.btnVideoStreaming.TabIndex = 7;
            this.btnVideoStreaming.Text = "Video Streaming";
            this.btnVideoStreaming.UseVisualStyleBackColor = true;
            this.btnVideoStreaming.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // PanelStudies
            // 
            this.PanelStudies.Controls.Add(this.button31);
            this.PanelStudies.Controls.Add(this.button32);
            this.PanelStudies.Controls.Add(this.btnWolframAlfa);
            this.PanelStudies.Controls.Add(this.btnWikipedia);
            this.PanelStudies.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStudies.Location = new System.Drawing.Point(0, 370);
            this.PanelStudies.Name = "PanelStudies";
            this.PanelStudies.Size = new System.Drawing.Size(344, 131);
            this.PanelStudies.TabIndex = 8;
            // 
            // button31
            // 
            this.button31.Dock = System.Windows.Forms.DockStyle.Top;
            this.button31.Location = new System.Drawing.Point(0, 98);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(344, 28);
            this.button31.TabIndex = 5;
            this.button31.Text = "StartPage";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Dock = System.Windows.Forms.DockStyle.Top;
            this.button32.Location = new System.Drawing.Point(0, 63);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(344, 35);
            this.button32.TabIndex = 4;
            this.button32.Text = "Bing";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // btnWolframAlfa
            // 
            this.btnWolframAlfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWolframAlfa.Location = new System.Drawing.Point(0, 30);
            this.btnWolframAlfa.Name = "btnWolframAlfa";
            this.btnWolframAlfa.Size = new System.Drawing.Size(344, 33);
            this.btnWolframAlfa.TabIndex = 3;
            this.btnWolframAlfa.Text = "WolframAlfa";
            this.btnWolframAlfa.UseVisualStyleBackColor = true;
            this.btnWolframAlfa.Click += new System.EventHandler(this.btnWolframAlfa_Click);
            // 
            // btnWikipedia
            // 
            this.btnWikipedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWikipedia.Location = new System.Drawing.Point(0, 0);
            this.btnWikipedia.Name = "btnWikipedia";
            this.btnWikipedia.Size = new System.Drawing.Size(344, 30);
            this.btnWikipedia.TabIndex = 1;
            this.btnWikipedia.Text = "Wikipedia";
            this.btnWikipedia.UseVisualStyleBackColor = true;
            this.btnWikipedia.Click += new System.EventHandler(this.btnWikipedia_Click);
            // 
            // btnStudies
            // 
            this.btnStudies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudies.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudies.Location = new System.Drawing.Point(0, 334);
            this.btnStudies.Name = "btnStudies";
            this.btnStudies.Size = new System.Drawing.Size(344, 36);
            this.btnStudies.TabIndex = 9;
            this.btnStudies.Text = "Studies";
            this.btnStudies.UseVisualStyleBackColor = true;
            this.btnStudies.Click += new System.EventHandler(this.btnStudies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelSearchEngine.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelVideoStreaming.ResumeLayout(false);
            this.PanelStudies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDDG;
        private System.Windows.Forms.Panel PanelSearchEngine;
        private System.Windows.Forms.Button btnSearchEngine;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStartPage;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelStudies;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button btnWolframAlfa;
        private System.Windows.Forms.Button btnWikipedia;
        private System.Windows.Forms.Button btnStudies;
        private System.Windows.Forms.Panel PanelVideoStreaming;
        private System.Windows.Forms.Button btnDailyMotion;
        private System.Windows.Forms.Button btnVimeo;
        private System.Windows.Forms.Button btnYoutubeMobile;
        private System.Windows.Forms.Button btnYoutube;
        private System.Windows.Forms.Button btnVideoStreaming;
    }
}

