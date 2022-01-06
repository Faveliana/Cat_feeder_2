
namespace WindowsFormsApp1
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.Create_user = new System.Windows.Forms.Button();
            this.add_feeder = new System.Windows.Forms.Button();
            this.check_the_status = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.get_info = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_user
            // 
            this.Create_user.Location = new System.Drawing.Point(242, 111);
            this.Create_user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Create_user.Name = "Create_user";
            this.Create_user.Size = new System.Drawing.Size(172, 29);
            this.Create_user.TabIndex = 1;
            this.Create_user.Text = "Create user";
            this.Create_user.UseVisualStyleBackColor = true;
            this.Create_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_feeder
            // 
            this.add_feeder.Location = new System.Drawing.Point(242, 183);
            this.add_feeder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_feeder.Name = "add_feeder";
            this.add_feeder.Size = new System.Drawing.Size(172, 29);
            this.add_feeder.TabIndex = 2;
            this.add_feeder.Text = "add feeder";
            this.add_feeder.UseVisualStyleBackColor = true;
            this.add_feeder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // check_the_status
            // 
            this.check_the_status.Location = new System.Drawing.Point(242, 241);
            this.check_the_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_the_status.Name = "check_the_status";
            this.check_the_status.Size = new System.Drawing.Size(172, 29);
            this.check_the_status.TabIndex = 3;
            this.check_the_status.Text = "check the status";
            this.check_the_status.UseVisualStyleBackColor = true;
            this.check_the_status.Click += new System.EventHandler(this.check_the_status_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // get_info
            // 
            this.get_info.Location = new System.Drawing.Point(242, 288);
            this.get_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.get_info.Name = "get_info";
            this.get_info.Size = new System.Drawing.Size(172, 32);
            this.get_info.TabIndex = 4;
            this.get_info.Text = "get info";
            this.get_info.UseVisualStyleBackColor = true;
            this.get_info.Click += new System.EventHandler(this.get_info_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            ////*this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            //this.pictureBox1.Location = new System.Drawing.Point(-103, -3);
            //this.pictureBox1.Name = "pictureBox1";
            //this.pictureBox1.Size = new System.Drawing.Size(899, 566);
            //this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            //this.pictureBox1.TabIndex = 6;
            //this.pictureBox1.TabStop = false;
            //this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.get_info);
            this.Controls.Add(this.check_the_status);
            this.Controls.Add(this.add_feeder);
            this.Controls.Add(this.Create_user);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "adminForm";
            this.Text = "adminForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Create_user;
        private System.Windows.Forms.Button add_feeder;
        private System.Windows.Forms.Button check_the_status;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button get_info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}