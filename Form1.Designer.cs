namespace TareaSemanSanta1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEncender = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelfondo = new System.Windows.Forms.Label();
            this.labelmsg = new System.Windows.Forms.Label();
            this.labelEstadoCarro = new System.Windows.Forms.Label();
            this.buttonAcel = new System.Windows.Forms.Button();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonBocinar = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.DarkRed;
            this.buttonEncender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEncender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEncender.Location = new System.Drawing.Point(227, 225);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(40, 25);
            this.buttonEncender.TabIndex = 0;
            this.buttonEncender.Text = "ON";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelfondo
            // 
            this.labelfondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelfondo.Location = new System.Drawing.Point(-2, 9);
            this.labelfondo.Name = "labelfondo";
            this.labelfondo.Size = new System.Drawing.Size(679, 58);
            this.labelfondo.TabIndex = 2;
            this.labelfondo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelmsg
            // 
            this.labelmsg.AutoSize = true;
            this.labelmsg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelmsg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelmsg.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelmsg.Location = new System.Drawing.Point(12, 42);
            this.labelmsg.Name = "labelmsg";
            this.labelmsg.Size = new System.Drawing.Size(18, 19);
            this.labelmsg.TabIndex = 3;
            this.labelmsg.Text = "...";
            // 
            // labelEstadoCarro
            // 
            this.labelEstadoCarro.AutoSize = true;
            this.labelEstadoCarro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelEstadoCarro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEstadoCarro.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelEstadoCarro.Location = new System.Drawing.Point(12, 9);
            this.labelEstadoCarro.Name = "labelEstadoCarro";
            this.labelEstadoCarro.Size = new System.Drawing.Size(18, 19);
            this.labelEstadoCarro.TabIndex = 4;
            this.labelEstadoCarro.Text = "...";
            // 
            // buttonAcel
            // 
            this.buttonAcel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAcel.ForeColor = System.Drawing.Color.Red;
            this.buttonAcel.Location = new System.Drawing.Point(212, 312);
            this.buttonAcel.Name = "buttonAcel";
            this.buttonAcel.Size = new System.Drawing.Size(22, 57);
            this.buttonAcel.TabIndex = 5;
            this.buttonAcel.Text = "GAS";
            this.buttonAcel.UseVisualStyleBackColor = false;
            this.buttonAcel.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFrenar.ForeColor = System.Drawing.Color.Red;
            this.buttonFrenar.Location = new System.Drawing.Point(161, 329);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(35, 40);
            this.buttonFrenar.TabIndex = 6;
            this.buttonFrenar.Text = "Break";
            this.buttonFrenar.UseVisualStyleBackColor = false;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPlay.Location = new System.Drawing.Point(278, 207);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(54, 23);
            this.buttonPlay.TabIndex = 7;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonStop.Location = new System.Drawing.Point(338, 207);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(60, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonBocinar
            // 
            this.buttonBocinar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBocinar.Location = new System.Drawing.Point(105, 227);
            this.buttonBocinar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBocinar.Name = "buttonBocinar";
            this.buttonBocinar.Size = new System.Drawing.Size(52, 23);
            this.buttonBocinar.TabIndex = 9;
            this.buttonBocinar.Text = "Bocinar";
            this.buttonBocinar.UseVisualStyleBackColor = false;
            this.buttonBocinar.Click += new System.EventHandler(this.buttonBocinar_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.BackColor = System.Drawing.Color.Black;
            this.buttonOff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOff.Location = new System.Drawing.Point(227, 256);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(40, 23);
            this.buttonOff.TabIndex = 10;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = false;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 410);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonBocinar);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonAcel);
            this.Controls.Add(this.labelEstadoCarro);
            this.Controls.Add(this.labelmsg);
            this.Controls.Add(this.labelfondo);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEncender;
        private PictureBox pictureBox1;
        private Label labelfondo;
        private Label labelmsg;
        private Label labelEstadoCarro;
        private Button buttonAcel;
        private Button buttonFrenar;
        private Button buttonPlay;
        private Button buttonStop;
        private Button buttonBocinar;
        private Button buttonOff;
    }
}