namespace VideoRentalSystem
{
    partial class VideoRentalSystem
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.Video = new System.Windows.Forms.TabPage();
            this.VideoDataGridView = new System.Windows.Forms.DataGridView();
            this.RentedVideos = new System.Windows.Forms.TabPage();
            this.RentedVideosDataGridView = new System.Windows.Forms.DataGridView();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.AllRented = new System.Windows.Forms.RadioButton();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.IssueVideo = new System.Windows.Forms.Button();
            this.ReturnVideo = new System.Windows.Forms.Button();
            this.OutRented = new System.Windows.Forms.RadioButton();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.VideoId = new System.Windows.Forms.TextBox();
            this.RentedCost = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.DeleteVideo = new System.Windows.Forms.Button();
            this.UpdateVideo = new System.Windows.Forms.Button();
            this.Genre = new System.Windows.Forms.TextBox();
            this.AddVideo = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoDataGridView)).BeginInit();
            this.RentedVideos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentedVideosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Customers);
            this.TabControl.Controls.Add(this.Video);
            this.TabControl.Controls.Add(this.RentedVideos);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(764, 296);
            this.TabControl.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.CustomersDataGridView);
            this.Customers.Location = new System.Drawing.Point(4, 22);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3);
            this.Customers.Size = new System.Drawing.Size(756, 270);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.Size = new System.Drawing.Size(744, 258);
            this.CustomersDataGridView.TabIndex = 0;
            this.CustomersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGridView_CellClick);
            // 
            // Video
            // 
            this.Video.Controls.Add(this.VideoDataGridView);
            this.Video.Location = new System.Drawing.Point(4, 22);
            this.Video.Name = "Video";
            this.Video.Padding = new System.Windows.Forms.Padding(3);
            this.Video.Size = new System.Drawing.Size(756, 270);
            this.Video.TabIndex = 1;
            this.Video.Text = "Video";
            this.Video.UseVisualStyleBackColor = true;
            // 
            // VideoDataGridView
            // 
            this.VideoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideoDataGridView.Location = new System.Drawing.Point(6, 6);
            this.VideoDataGridView.Name = "VideoDataGridView";
            this.VideoDataGridView.Size = new System.Drawing.Size(744, 261);
            this.VideoDataGridView.TabIndex = 0;
            this.VideoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VideoDataGridView_CellClick);
            // 
            // RentedVideos
            // 
            this.RentedVideos.Controls.Add(this.RentedVideosDataGridView);
            this.RentedVideos.Location = new System.Drawing.Point(4, 22);
            this.RentedVideos.Name = "RentedVideos";
            this.RentedVideos.Size = new System.Drawing.Size(756, 270);
            this.RentedVideos.TabIndex = 2;
            this.RentedVideos.Text = "RentedVideos";
            this.RentedVideos.UseVisualStyleBackColor = true;
            // 
            // RentedVideosDataGridView
            // 
            this.RentedVideosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentedVideosDataGridView.Location = new System.Drawing.Point(3, 3);
            this.RentedVideosDataGridView.Name = "RentedVideosDataGridView";
            this.RentedVideosDataGridView.Size = new System.Drawing.Size(750, 264);
            this.RentedVideosDataGridView.TabIndex = 0;
            this.RentedVideosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentedVideosDataGridView_CellClick);
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(128, 314);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(100, 23);
            this.AddCustomer.TabIndex = 1;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(88, 358);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 2;
            // 
            // AllRented
            // 
            this.AllRented.AutoSize = true;
            this.AllRented.Checked = true;
            this.AllRented.Location = new System.Drawing.Point(680, 416);
            this.AllRented.Name = "AllRented";
            this.AllRented.Size = new System.Drawing.Size(74, 17);
            this.AllRented.TabIndex = 3;
            this.AllRented.TabStop = true;
            this.AllRented.Text = "All Rented";
            this.AllRented.UseVisualStyleBackColor = true;
            this.AllRented.CheckedChanged += new System.EventHandler(this.AllRented_CheckedChanged);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.Location = new System.Drawing.Point(273, 314);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(100, 23);
            this.UpdateCustomer.TabIndex = 4;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = true;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Location = new System.Drawing.Point(409, 314);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(105, 23);
            this.DeleteCustomer.TabIndex = 5;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // IssueVideo
            // 
            this.IssueVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IssueVideo.Location = new System.Drawing.Point(622, 332);
            this.IssueVideo.Name = "IssueVideo";
            this.IssueVideo.Size = new System.Drawing.Size(75, 46);
            this.IssueVideo.TabIndex = 6;
            this.IssueVideo.Text = "Issue Video";
            this.IssueVideo.UseVisualStyleBackColor = false;
            this.IssueVideo.Click += new System.EventHandler(this.IssueVideo_Click);
            // 
            // ReturnVideo
            // 
            this.ReturnVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReturnVideo.Location = new System.Drawing.Point(712, 332);
            this.ReturnVideo.Name = "ReturnVideo";
            this.ReturnVideo.Size = new System.Drawing.Size(75, 46);
            this.ReturnVideo.TabIndex = 7;
            this.ReturnVideo.Text = "Return Video";
            this.ReturnVideo.UseVisualStyleBackColor = false;
            this.ReturnVideo.Click += new System.EventHandler(this.ReturnVideo_Click);
            // 
            // OutRented
            // 
            this.OutRented.AutoSize = true;
            this.OutRented.Location = new System.Drawing.Point(680, 448);
            this.OutRented.Name = "OutRented";
            this.OutRented.Size = new System.Drawing.Size(80, 17);
            this.OutRented.TabIndex = 8;
            this.OutRented.Text = "Out Rented";
            this.OutRented.UseVisualStyleBackColor = true;
            this.OutRented.CheckedChanged += new System.EventHandler(this.OutRented_CheckedChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(219, 358);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 9;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(353, 358);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 20);
            this.Address.TabIndex = 10;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(485, 358);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumber.TabIndex = 11;
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(24, 358);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(30, 20);
            this.CustomerID.TabIndex = 12;
            // 
            // VideoId
            // 
            this.VideoId.Location = new System.Drawing.Point(24, 460);
            this.VideoId.Name = "VideoId";
            this.VideoId.Size = new System.Drawing.Size(30, 20);
            this.VideoId.TabIndex = 20;
            // 
            // RentedCost
            // 
            this.RentedCost.Location = new System.Drawing.Point(485, 460);
            this.RentedCost.Name = "RentedCost";
            this.RentedCost.Size = new System.Drawing.Size(100, 20);
            this.RentedCost.TabIndex = 19;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(353, 460);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(100, 20);
            this.Year.TabIndex = 18;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(219, 460);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 20);
            this.Title.TabIndex = 17;
            // 
            // DeleteVideo
            // 
            this.DeleteVideo.Location = new System.Drawing.Point(409, 413);
            this.DeleteVideo.Name = "DeleteVideo";
            this.DeleteVideo.Size = new System.Drawing.Size(105, 23);
            this.DeleteVideo.TabIndex = 16;
            this.DeleteVideo.Text = "Delete Video";
            this.DeleteVideo.UseVisualStyleBackColor = true;
            this.DeleteVideo.Click += new System.EventHandler(this.DeleteVideo_Click);
            // 
            // UpdateVideo
            // 
            this.UpdateVideo.Location = new System.Drawing.Point(273, 413);
            this.UpdateVideo.Name = "UpdateVideo";
            this.UpdateVideo.Size = new System.Drawing.Size(100, 23);
            this.UpdateVideo.TabIndex = 15;
            this.UpdateVideo.Text = "Update Video";
            this.UpdateVideo.UseVisualStyleBackColor = true;
            this.UpdateVideo.Click += new System.EventHandler(this.UpdateVideo_Click);
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(88, 460);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(100, 20);
            this.Genre.TabIndex = 14;
            // 
            // AddVideo
            // 
            this.AddVideo.Location = new System.Drawing.Point(128, 413);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(100, 23);
            this.AddVideo.TabIndex = 13;
            this.AddVideo.Text = "Add Video";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // VideoRentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 495);
            this.Controls.Add(this.VideoId);
            this.Controls.Add(this.RentedCost);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DeleteVideo);
            this.Controls.Add(this.UpdateVideo);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.AddVideo);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.OutRented);
            this.Controls.Add(this.ReturnVideo);
            this.Controls.Add(this.IssueVideo);
            this.Controls.Add(this.DeleteCustomer);
            this.Controls.Add(this.UpdateCustomer);
            this.Controls.Add(this.AllRented);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.TabControl);
            this.Name = "VideoRentalSystem";
            this.Text = "Video Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.Video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoDataGridView)).EndInit();
            this.RentedVideos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentedVideosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.TabPage Video;
        private System.Windows.Forms.DataGridView VideoDataGridView;
        private System.Windows.Forms.TabPage RentedVideos;
        private System.Windows.Forms.DataGridView RentedVideosDataGridView;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.RadioButton AllRented;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button IssueVideo;
        private System.Windows.Forms.Button ReturnVideo;
        private System.Windows.Forms.RadioButton OutRented;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.TextBox VideoId;
        private System.Windows.Forms.TextBox RentedCost;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button DeleteVideo;
        private System.Windows.Forms.Button UpdateVideo;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Button AddVideo;
    }
}

