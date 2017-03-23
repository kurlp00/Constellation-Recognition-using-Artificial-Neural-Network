namespace ConstellationRecognitionANN
{
    partial class ArtificialNeuralNetworkForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConstellation = new System.Windows.Forms.TextBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.btnTrainNetwork = new System.Windows.Forms.Button();
            this.outputPicture = new System.Windows.Forms.PictureBox();
            this.openPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChoice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDebug);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(347, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug Panel";
            // 
            // txtDebug
            // 
            this.txtDebug.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebug.Location = new System.Drawing.Point(6, 28);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebug.Size = new System.Drawing.Size(280, 305);
            this.txtDebug.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConstellation);
            this.groupBox2.Controls.Add(this.btnRecognize);
            this.groupBox2.Controls.Add(this.btnTrainNetwork);
            this.groupBox2.Controls.Add(this.outputPicture);
            this.groupBox2.Controls.Add(this.openPictureBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnChoice);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 339);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ANN Panel";
            // 
            // txtConstellation
            // 
            this.txtConstellation.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConstellation.Location = new System.Drawing.Point(172, 206);
            this.txtConstellation.Multiline = true;
            this.txtConstellation.Name = "txtConstellation";
            this.txtConstellation.Size = new System.Drawing.Size(151, 20);
            this.txtConstellation.TabIndex = 6;
            this.txtConstellation.Visible = false;
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(172, 253);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(151, 56);
            this.btnRecognize.TabIndex = 5;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // btnTrainNetwork
            // 
            this.btnTrainNetwork.Location = new System.Drawing.Point(6, 253);
            this.btnTrainNetwork.Name = "btnTrainNetwork";
            this.btnTrainNetwork.Size = new System.Drawing.Size(151, 56);
            this.btnTrainNetwork.TabIndex = 4;
            this.btnTrainNetwork.Text = "Train Network";
            this.btnTrainNetwork.UseVisualStyleBackColor = true;
            this.btnTrainNetwork.Click += new System.EventHandler(this.btnTrainNetwork_Click);
            // 
            // outputPicture
            // 
            this.outputPicture.Location = new System.Drawing.Point(172, 88);
            this.outputPicture.Name = "outputPicture";
            this.outputPicture.Size = new System.Drawing.Size(151, 111);
            this.outputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outputPicture.TabIndex = 3;
            this.outputPicture.TabStop = false;
            // 
            // openPictureBox
            // 
            this.openPictureBox.Location = new System.Drawing.Point(6, 88);
            this.openPictureBox.Name = "openPictureBox";
            this.openPictureBox.Size = new System.Drawing.Size(151, 139);
            this.openPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openPictureBox.TabIndex = 2;
            this.openPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Image: ";
            // 
            // btnChoice
            // 
            this.btnChoice.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice.Location = new System.Drawing.Point(152, 35);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(96, 23);
            this.btnChoice.TabIndex = 0;
            this.btnChoice.Text = "Choose";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // ArtificialNeuralNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ArtificialNeuralNetworkForm";
            this.Text = "Constellation Recognition";
            this.Load += new System.EventHandler(this.ArtificialNeuralNetworkForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.PictureBox outputPicture;
        private System.Windows.Forms.PictureBox openPictureBox;
        private System.Windows.Forms.Button btnTrainNetwork;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.TextBox txtConstellation;

    }
}

