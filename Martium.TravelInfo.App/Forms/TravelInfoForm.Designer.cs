﻿
namespace Martium.TravelInfo.App.Forms
{
    partial class TravelInfoForm
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
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.TripDurationTextBox = new System.Windows.Forms.TextBox();
            this.TripDurationLabel = new System.Windows.Forms.Label();
            this.ArrivalCountryTextLabel = new System.Windows.Forms.Label();
            this.DepartureCountryTextLabel = new System.Windows.Forms.Label();
            this.ArrivalCountryLabel = new System.Windows.Forms.Label();
            this.ArrivalCountryComboBox = new System.Windows.Forms.ComboBox();
            this.DepartureCountryComboBox = new System.Windows.Forms.ComboBox();
            this.DecimalTextBoxErrorLabel = new System.Windows.Forms.Label();
            this.SaveDepartureAddressButton = new System.Windows.Forms.Button();
            this.ArrivalAddressTextBox = new System.Windows.Forms.TextBox();
            this.ArrivalAdressLabel = new System.Windows.Forms.Label();
            this.DepartureAddressTextBox = new System.Windows.Forms.TextBox();
            this.DepartureAddressLabel = new System.Windows.Forms.Label();
            this.SaveAdditionalDistanceInKmButton = new System.Windows.Forms.Button();
            this.SavePricePerKmButton = new System.Windows.Forms.Button();
            this.AdditionalKmLabel = new System.Windows.Forms.Label();
            this.AdditionalDistanceInKmTextBox = new System.Windows.Forms.TextBox();
            this.OneWayTripPriceTextBox = new System.Windows.Forms.TextBox();
            this.TripDistanceTextBox = new System.Windows.Forms.TextBox();
            this.OneWayTripPriceLabel = new System.Windows.Forms.Label();
            this.CalculateTripCostButton = new System.Windows.Forms.Button();
            this.TripDistanceLabel = new System.Windows.Forms.Label();
            this.SearchRouteButton = new System.Windows.Forms.Button();
            this.PricePerKm = new System.Windows.Forms.TextBox();
            this.FuelPriceLabel = new System.Windows.Forms.Label();
            this.DepartureCountryLabel = new System.Windows.Forms.Label();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.MapContributorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ReturnIncludedTripPriceTextBox = new System.Windows.Forms.TextBox();
            this.ReturnIncludedTripPriceLabel = new System.Windows.Forms.Label();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.ReturnIncludedTripPriceLabel);
            this.InfoPanel.Controls.Add(this.ReturnIncludedTripPriceTextBox);
            this.InfoPanel.Controls.Add(this.TripDurationTextBox);
            this.InfoPanel.Controls.Add(this.TripDurationLabel);
            this.InfoPanel.Controls.Add(this.ArrivalCountryTextLabel);
            this.InfoPanel.Controls.Add(this.DepartureCountryTextLabel);
            this.InfoPanel.Controls.Add(this.ArrivalCountryLabel);
            this.InfoPanel.Controls.Add(this.ArrivalCountryComboBox);
            this.InfoPanel.Controls.Add(this.DepartureCountryComboBox);
            this.InfoPanel.Controls.Add(this.DecimalTextBoxErrorLabel);
            this.InfoPanel.Controls.Add(this.SaveDepartureAddressButton);
            this.InfoPanel.Controls.Add(this.ArrivalAddressTextBox);
            this.InfoPanel.Controls.Add(this.ArrivalAdressLabel);
            this.InfoPanel.Controls.Add(this.DepartureAddressTextBox);
            this.InfoPanel.Controls.Add(this.DepartureAddressLabel);
            this.InfoPanel.Controls.Add(this.SaveAdditionalDistanceInKmButton);
            this.InfoPanel.Controls.Add(this.SavePricePerKmButton);
            this.InfoPanel.Controls.Add(this.AdditionalKmLabel);
            this.InfoPanel.Controls.Add(this.AdditionalDistanceInKmTextBox);
            this.InfoPanel.Controls.Add(this.OneWayTripPriceTextBox);
            this.InfoPanel.Controls.Add(this.TripDistanceTextBox);
            this.InfoPanel.Controls.Add(this.OneWayTripPriceLabel);
            this.InfoPanel.Controls.Add(this.CalculateTripCostButton);
            this.InfoPanel.Controls.Add(this.TripDistanceLabel);
            this.InfoPanel.Controls.Add(this.SearchRouteButton);
            this.InfoPanel.Controls.Add(this.PricePerKm);
            this.InfoPanel.Controls.Add(this.FuelPriceLabel);
            this.InfoPanel.Controls.Add(this.DepartureCountryLabel);
            this.InfoPanel.Location = new System.Drawing.Point(-3, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(347, 669);
            this.InfoPanel.TabIndex = 0;
            // 
            // CalculatedDurationTextBox
            // 
            this.TripDurationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TripDurationTextBox.Location = new System.Drawing.Point(100, 253);
            this.TripDurationTextBox.Name = "TripDurationTextBox";
            this.TripDurationTextBox.Size = new System.Drawing.Size(106, 20);
            this.TripDurationTextBox.TabIndex = 28;
            // 
            // CalculatedDurationLabel
            // 
            this.TripDurationLabel.AutoSize = true;
            this.TripDurationLabel.Location = new System.Drawing.Point(23, 256);
            this.TripDurationLabel.Name = "TripDurationLabel";
            this.TripDurationLabel.Size = new System.Drawing.Size(46, 13);
            this.TripDurationLabel.TabIndex = 27;
            this.TripDurationLabel.Text = "Trukmė:";
            // 
            // ArrivalCountryTextLabel
            // 
            this.ArrivalCountryTextLabel.AutoSize = true;
            this.ArrivalCountryTextLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ArrivalCountryTextLabel.Location = new System.Drawing.Point(68, 129);
            this.ArrivalCountryTextLabel.Name = "ArrivalCountryTextLabel";
            this.ArrivalCountryTextLabel.Size = new System.Drawing.Size(128, 13);
            this.ArrivalCountryTextLabel.TabIndex = 26;
            this.ArrivalCountryTextLabel.Text = "Arrival country name label";
            // 
            // DepartureCountryTextLabel
            // 
            this.DepartureCountryTextLabel.AutoSize = true;
            this.DepartureCountryTextLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DepartureCountryTextLabel.Location = new System.Drawing.Point(70, 38);
            this.DepartureCountryTextLabel.Name = "DepartureCountryTextLabel";
            this.DepartureCountryTextLabel.Size = new System.Drawing.Size(146, 13);
            this.DepartureCountryTextLabel.TabIndex = 25;
            this.DepartureCountryTextLabel.Text = "Departure country name label";
            // 
            // ArrivalCountryLabel
            // 
            this.ArrivalCountryLabel.AutoSize = true;
            this.ArrivalCountryLabel.Location = new System.Drawing.Point(17, 110);
            this.ArrivalCountryLabel.Name = "ArrivalCountryLabel";
            this.ArrivalCountryLabel.Size = new System.Drawing.Size(73, 13);
            this.ArrivalCountryLabel.TabIndex = 24;
            this.ArrivalCountryLabel.Text = "Atvykimo šalis";
            // 
            // ArrivalCountryComboBox
            // 
            this.ArrivalCountryComboBox.FormattingEnabled = true;
            this.ArrivalCountryComboBox.Location = new System.Drawing.Point(18, 126);
            this.ArrivalCountryComboBox.Name = "ArrivalCountryComboBox";
            this.ArrivalCountryComboBox.Size = new System.Drawing.Size(44, 21);
            this.ArrivalCountryComboBox.TabIndex = 23;
            this.ArrivalCountryComboBox.SelectedIndexChanged += new System.EventHandler(this.ArrivalCountryComboBox_SelectedIndexChanged);
            // 
            // DepartureCountryComboBox
            // 
            this.DepartureCountryComboBox.FormattingEnabled = true;
            this.DepartureCountryComboBox.Location = new System.Drawing.Point(20, 35);
            this.DepartureCountryComboBox.Name = "DepartureCountryComboBox";
            this.DepartureCountryComboBox.Size = new System.Drawing.Size(44, 21);
            this.DepartureCountryComboBox.TabIndex = 22;
            this.DepartureCountryComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartureCountryComboBox_SelectedIndexChanged);
            // 
            // DecimalTextBoxErrorLabel
            // 
            this.DecimalTextBoxErrorLabel.AutoSize = true;
            this.DecimalTextBoxErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.DecimalTextBoxErrorLabel.Location = new System.Drawing.Point(17, 399);
            this.DecimalTextBoxErrorLabel.Name = "DecimalTextBoxErrorLabel";
            this.DecimalTextBoxErrorLabel.Size = new System.Drawing.Size(49, 13);
            this.DecimalTextBoxErrorLabel.TabIndex = 21;
            this.DecimalTextBoxErrorLabel.Text = "Error text";
            this.DecimalTextBoxErrorLabel.Visible = false;
            // 
            // SaveDepartureAddressButton
            // 
            this.SaveDepartureAddressButton.Location = new System.Drawing.Point(239, 74);
            this.SaveDepartureAddressButton.Name = "SaveDepartureAddressButton";
            this.SaveDepartureAddressButton.Size = new System.Drawing.Size(71, 22);
            this.SaveDepartureAddressButton.TabIndex = 20;
            this.SaveDepartureAddressButton.Text = "Išsaugoti";
            this.SaveDepartureAddressButton.UseVisualStyleBackColor = true;
            this.SaveDepartureAddressButton.Click += new System.EventHandler(this.SaveDepartureAddressButton_Click);
            // 
            // ArrivalAddressTextBox
            // 
            this.ArrivalAddressTextBox.Location = new System.Drawing.Point(20, 166);
            this.ArrivalAddressTextBox.Name = "ArrivalAddressTextBox";
            this.ArrivalAddressTextBox.Size = new System.Drawing.Size(215, 20);
            this.ArrivalAddressTextBox.TabIndex = 19;
            this.ArrivalAddressTextBox.TextChanged += new System.EventHandler(this.ArrivalAddressTextBox_TextChanged);
            // 
            // ArrivalAdressLabel
            // 
            this.ArrivalAdressLabel.AutoSize = true;
            this.ArrivalAdressLabel.Location = new System.Drawing.Point(17, 150);
            this.ArrivalAdressLabel.Name = "ArrivalAdressLabel";
            this.ArrivalAdressLabel.Size = new System.Drawing.Size(90, 13);
            this.ArrivalAdressLabel.TabIndex = 18;
            this.ArrivalAdressLabel.Text = "Atvykimo adresas";
            // 
            // DepartureAddressTextBox
            // 
            this.DepartureAddressTextBox.Location = new System.Drawing.Point(20, 75);
            this.DepartureAddressTextBox.Name = "DepartureAddressTextBox";
            this.DepartureAddressTextBox.Size = new System.Drawing.Size(215, 20);
            this.DepartureAddressTextBox.TabIndex = 17;
            this.DepartureAddressTextBox.TextChanged += new System.EventHandler(this.DepartureAddressTextBox_TextChanged);
            // 
            // DepartureAddressLabel
            // 
            this.DepartureAddressLabel.AutoSize = true;
            this.DepartureAddressLabel.Location = new System.Drawing.Point(17, 59);
            this.DepartureAddressLabel.Name = "DepartureAddressLabel";
            this.DepartureAddressLabel.Size = new System.Drawing.Size(88, 13);
            this.DepartureAddressLabel.TabIndex = 16;
            this.DepartureAddressLabel.Text = "Išvykimo adresas";
            // 
            // SaveAdditionalDistanceInKmButton
            // 
            this.SaveAdditionalDistanceInKmButton.Location = new System.Drawing.Point(126, 375);
            this.SaveAdditionalDistanceInKmButton.Name = "SaveAdditionalDistanceInKmButton";
            this.SaveAdditionalDistanceInKmButton.Size = new System.Drawing.Size(71, 22);
            this.SaveAdditionalDistanceInKmButton.TabIndex = 15;
            this.SaveAdditionalDistanceInKmButton.Text = "Išsaugoti";
            this.SaveAdditionalDistanceInKmButton.UseVisualStyleBackColor = true;
            this.SaveAdditionalDistanceInKmButton.Click += new System.EventHandler(this.SaveAdditionalDistanceInKmButton_Click);
            // 
            // SavePricePerKmButton
            // 
            this.SavePricePerKmButton.Location = new System.Drawing.Point(126, 336);
            this.SavePricePerKmButton.Name = "SavePricePerKmButton";
            this.SavePricePerKmButton.Size = new System.Drawing.Size(71, 22);
            this.SavePricePerKmButton.TabIndex = 14;
            this.SavePricePerKmButton.Text = "Išsaugoti";
            this.SavePricePerKmButton.UseVisualStyleBackColor = true;
            this.SavePricePerKmButton.Click += new System.EventHandler(this.SavePricePerKmButton_Click);
            // 
            // AdditionalKmLabel
            // 
            this.AdditionalKmLabel.AutoSize = true;
            this.AdditionalKmLabel.Location = new System.Drawing.Point(17, 360);
            this.AdditionalKmLabel.Name = "AdditionalKmLabel";
            this.AdditionalKmLabel.Size = new System.Drawing.Size(99, 13);
            this.AdditionalKmLabel.TabIndex = 13;
            this.AdditionalKmLabel.Text = "Papildomi kilometrai";
            // 
            // AdditionalDistanceInKmTextBox
            // 
            this.AdditionalDistanceInKmTextBox.Location = new System.Drawing.Point(20, 376);
            this.AdditionalDistanceInKmTextBox.Name = "AdditionalDistanceInKmTextBox";
            this.AdditionalDistanceInKmTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdditionalDistanceInKmTextBox.TabIndex = 12;
            this.AdditionalDistanceInKmTextBox.TextChanged += new System.EventHandler(this.AdditionalDistanceInKm_TextChanged);
            this.AdditionalDistanceInKmTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AdditionalDistanceInKmTextBox_Validating);
            // 
            // CalculatedOneWayTripPriceTextBox
            // 
            this.OneWayTripPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.OneWayTripPriceTextBox.Location = new System.Drawing.Point(126, 491);
            this.OneWayTripPriceTextBox.Name = "OneWayTripPriceTextBox";
            this.OneWayTripPriceTextBox.Size = new System.Drawing.Size(106, 20);
            this.OneWayTripPriceTextBox.TabIndex = 11;
            // 
            // CalculatedDistanceTextBox
            // 
            this.TripDistanceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TripDistanceTextBox.Location = new System.Drawing.Point(100, 224);
            this.TripDistanceTextBox.Name = "TripDistanceTextBox";
            this.TripDistanceTextBox.Size = new System.Drawing.Size(106, 20);
            this.TripDistanceTextBox.TabIndex = 10;
            // 
            // CalculatedOneWayTripPriceLabel
            // 
            this.OneWayTripPriceLabel.AutoSize = true;
            this.OneWayTripPriceLabel.Location = new System.Drawing.Point(21, 491);
            this.OneWayTripPriceLabel.Name = "OneWayTripPriceLabel";
            this.OneWayTripPriceLabel.Size = new System.Drawing.Size(92, 13);
            this.OneWayTripPriceLabel.TabIndex = 9;
            this.OneWayTripPriceLabel.Text = "Kaina vieną pusę:";
            // 
            // CalculateButton
            // 
            this.CalculateTripCostButton.Location = new System.Drawing.Point(126, 435);
            this.CalculateTripCostButton.Name = "CalculateTripCostButton";
            this.CalculateTripCostButton.Size = new System.Drawing.Size(94, 40);
            this.CalculateTripCostButton.TabIndex = 8;
            this.CalculateTripCostButton.Text = "Skaičiuoti kelionės kainą";
            this.CalculateTripCostButton.UseVisualStyleBackColor = true;
            this.CalculateTripCostButton.Click += new System.EventHandler(this.CalculateTripPriceButton_Click);
            // 
            // CalculatedDistanceLabel
            // 
            this.TripDistanceLabel.AutoSize = true;
            this.TripDistanceLabel.Location = new System.Drawing.Point(21, 227);
            this.TripDistanceLabel.Name = "TripDistanceLabel";
            this.TripDistanceLabel.Size = new System.Drawing.Size(73, 13);
            this.TripDistanceLabel.TabIndex = 7;
            this.TripDistanceLabel.Text = "Atstumas, km:";
            // 
            // SearchRouteButton
            // 
            this.SearchRouteButton.Location = new System.Drawing.Point(20, 192);
            this.SearchRouteButton.Name = "SearchRouteButton";
            this.SearchRouteButton.Size = new System.Drawing.Size(70, 22);
            this.SearchRouteButton.TabIndex = 6;
            this.SearchRouteButton.Text = "Ieškoti";
            this.SearchRouteButton.UseVisualStyleBackColor = true;
            this.SearchRouteButton.Click += new System.EventHandler(this.SearchRouteButton_Click);
            // 
            // PricePerKm
            // 
            this.PricePerKm.Location = new System.Drawing.Point(20, 337);
            this.PricePerKm.Name = "PricePerKm";
            this.PricePerKm.Size = new System.Drawing.Size(100, 20);
            this.PricePerKm.TabIndex = 5;
            this.PricePerKm.TextChanged += new System.EventHandler(this.PricePerKm_TextChanged);
            this.PricePerKm.Validating += new System.ComponentModel.CancelEventHandler(this.PricePerKm_Validating);
            // 
            // FuelPriceLabel
            // 
            this.FuelPriceLabel.AutoSize = true;
            this.FuelPriceLabel.Location = new System.Drawing.Point(17, 321);
            this.FuelPriceLabel.Name = "FuelPriceLabel";
            this.FuelPriceLabel.Size = new System.Drawing.Size(79, 13);
            this.FuelPriceLabel.TabIndex = 4;
            this.FuelPriceLabel.Text = "Kilometro kaina";
            // 
            // DepartureCountryLabel
            // 
            this.DepartureCountryLabel.AutoSize = true;
            this.DepartureCountryLabel.Location = new System.Drawing.Point(15, 19);
            this.DepartureCountryLabel.Name = "DepartureCountryLabel";
            this.DepartureCountryLabel.Size = new System.Drawing.Size(71, 13);
            this.DepartureCountryLabel.TabIndex = 0;
            this.DepartureCountryLabel.Text = "Išvykimo šalis";
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(344, 0);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 18;
            this.Map.MinZoom = 2;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = true;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = true;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(724, 641);
            this.Map.TabIndex = 1;
            this.Map.Zoom = 13D;
            // 
            // MapContributorLinkLabel
            // 
            this.MapContributorLinkLabel.AutoSize = true;
            this.MapContributorLinkLabel.Location = new System.Drawing.Point(641, 644);
            this.MapContributorLinkLabel.Name = "MapContributorLinkLabel";
            this.MapContributorLinkLabel.Size = new System.Drawing.Size(152, 13);
            this.MapContributorLinkLabel.TabIndex = 2;
            this.MapContributorLinkLabel.TabStop = true;
            this.MapContributorLinkLabel.Text = "© OpenStreetMap contributors";
            this.MapContributorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MapContributorLinkLabel_LinkClicked);
            // 
            // CalculateTwoWaysTripPriceTextBox
            // 
            this.ReturnIncludedTripPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ReturnIncludedTripPriceTextBox.Location = new System.Drawing.Point(126, 517);
            this.ReturnIncludedTripPriceTextBox.Name = "ReturnIncludedTripPriceTextBox";
            this.ReturnIncludedTripPriceTextBox.Size = new System.Drawing.Size(106, 20);
            this.ReturnIncludedTripPriceTextBox.TabIndex = 29;
            // 
            // CalculateTwoWaysTripPriceLabel
            // 
            this.ReturnIncludedTripPriceLabel.AutoSize = true;
            this.ReturnIncludedTripPriceLabel.Location = new System.Drawing.Point(21, 520);
            this.ReturnIncludedTripPriceLabel.Name = "ReturnIncludedTripPriceLabel";
            this.ReturnIncludedTripPriceLabel.Size = new System.Drawing.Size(96, 13);
            this.ReturnIncludedTripPriceLabel.TabIndex = 30;
            this.ReturnIncludedTripPriceLabel.Text = "Kaina pirmyn atgal:";
            // 
            // TravelInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 666);
            this.Controls.Add(this.MapContributorLinkLabel);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.InfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TravelInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelionės skaičiuoklė";
            this.Load += new System.EventHandler(this.TravelInfoForm_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox PricePerKm;
        private System.Windows.Forms.Label FuelPriceLabel;
        private System.Windows.Forms.Label DepartureCountryLabel;
        private System.Windows.Forms.Label TripDistanceLabel;
        private System.Windows.Forms.Button SearchRouteButton;
        private System.Windows.Forms.TextBox TripDistanceTextBox;
        private System.Windows.Forms.Label OneWayTripPriceLabel;
        private System.Windows.Forms.Button CalculateTripCostButton;
        private System.Windows.Forms.TextBox OneWayTripPriceTextBox;
        private System.Windows.Forms.Button SaveAdditionalDistanceInKmButton;
        private System.Windows.Forms.Button SavePricePerKmButton;
        private System.Windows.Forms.Label AdditionalKmLabel;
        private System.Windows.Forms.TextBox AdditionalDistanceInKmTextBox;
        private System.Windows.Forms.Label ArrivalAdressLabel;
        private System.Windows.Forms.TextBox DepartureAddressTextBox;
        private System.Windows.Forms.Label DepartureAddressLabel;
        private System.Windows.Forms.TextBox ArrivalAddressTextBox;
        private GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.LinkLabel MapContributorLinkLabel;
        private System.Windows.Forms.Button SaveDepartureAddressButton;
        private System.Windows.Forms.Label DecimalTextBoxErrorLabel;
        private System.Windows.Forms.ComboBox DepartureCountryComboBox;
        private System.Windows.Forms.Label ArrivalCountryLabel;
        private System.Windows.Forms.ComboBox ArrivalCountryComboBox;
        private System.Windows.Forms.Label ArrivalCountryTextLabel;
        private System.Windows.Forms.Label DepartureCountryTextLabel;
        private System.Windows.Forms.TextBox TripDurationTextBox;
        private System.Windows.Forms.Label TripDurationLabel;
        private System.Windows.Forms.Label ReturnIncludedTripPriceLabel;
        private System.Windows.Forms.TextBox ReturnIncludedTripPriceTextBox;
    }
}

