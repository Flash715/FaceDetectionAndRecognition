
namespace FaceDetectionAndRecognition
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
            this.components = new System.ComponentModel.Container();
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(30, 12);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(435, 330);
            this.cameraBox.TabIndex = 2;
            this.cameraBox.TabStop = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(163, 348);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(144, 69);
            this.start.TabIndex = 3;
            this.start.Text = "Mulai Deteksi";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 445);
            this.Controls.Add(this.start);
            this.Controls.Add(this.cameraBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button start;
    }
}

