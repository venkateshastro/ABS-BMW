
namespace BMW_ABS
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
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.indicatorGroup = new System.Windows.Forms.GroupBox();
            this.flattireCheck = new System.Windows.Forms.CheckBox();
            this.brakepadCheck = new System.Windows.Forms.CheckBox();
            this.featureGroup = new System.Windows.Forms.GroupBox();
            this.brakepadGroup = new System.Windows.Forms.GroupBox();
            this.brakepadrearCheck = new System.Windows.Forms.CheckBox();
            this.brakepadfrontCheck = new System.Windows.Forms.CheckBox();
            this.yawmomentCheck = new System.Windows.Forms.CheckBox();
            this.brakefadingCheck = new System.Windows.Forms.CheckBox();
            this.brakedryCheck = new System.Windows.Forms.CheckBox();
            this.softstopCheck = new System.Windows.Forms.CheckBox();
            this.rotationCheck = new System.Windows.Forms.CheckBox();
            this.activefrontCheck = new System.Windows.Forms.CheckBox();
            this.reductionCheck = new System.Windows.Forms.CheckBox();
            this.oversteerTrack = new System.Windows.Forms.TrackBar();
            this.oversteerLabel = new System.Windows.Forms.Label();
            this.oversteerlowLabel = new System.Windows.Forms.Label();
            this.oversteerhighLabel = new System.Windows.Forms.Label();
            this.understeerLabel = new System.Windows.Forms.Label();
            this.understeerTrack = new System.Windows.Forms.TrackBar();
            this.deltapsiLabel = new System.Windows.Forms.Label();
            this.deltapsiTrack = new System.Windows.Forms.TrackBar();
            this.anglecurveLabel = new System.Windows.Forms.Label();
            this.anglecurveTrack = new System.Windows.Forms.TrackBar();
            this.startoffLabel = new System.Windows.Forms.Label();
            this.startoffTrack = new System.Windows.Forms.TrackBar();
            this.startoffoffLabel = new System.Windows.Forms.Label();
            this.yawmomentGroup = new System.Windows.Forms.GroupBox();
            this.yawmomentLargeLabel = new System.Windows.Forms.Label();
            this.yawmoment0Label = new System.Windows.Forms.Label();
            this.yawmomentrearTrack = new System.Windows.Forms.TrackBar();
            this.yawmomwntrearLabel = new System.Windows.Forms.Label();
            this.yawmomentfrontTrack = new System.Windows.Forms.TrackBar();
            this.yawmomentfrontLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.creditsLabel = new System.Windows.Forms.Label();
            this.indicatorGroup.SuspendLayout();
            this.featureGroup.SuspendLayout();
            this.brakepadGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oversteerTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.understeerTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltapsiTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anglecurveTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startoffTrack)).BeginInit();
            this.yawmomentGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yawmomentrearTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawmomentfrontTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(250, 413);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(80, 32);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "Import...";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Enabled = false;
            this.exportButton.Location = new System.Drawing.Point(333, 413);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(80, 32);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export...";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(432, 413);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // indicatorGroup
            // 
            this.indicatorGroup.Controls.Add(this.flattireCheck);
            this.indicatorGroup.Controls.Add(this.brakepadCheck);
            this.indicatorGroup.Location = new System.Drawing.Point(250, 12);
            this.indicatorGroup.Name = "indicatorGroup";
            this.indicatorGroup.Size = new System.Drawing.Size(262, 79);
            this.indicatorGroup.TabIndex = 3;
            this.indicatorGroup.TabStop = false;
            this.indicatorGroup.Text = "Indicators";
            // 
            // flattireCheck
            // 
            this.flattireCheck.AutoSize = true;
            this.flattireCheck.Location = new System.Drawing.Point(7, 49);
            this.flattireCheck.Name = "flattireCheck";
            this.flattireCheck.Size = new System.Drawing.Size(77, 21);
            this.flattireCheck.TabIndex = 1;
            this.flattireCheck.Text = "Flat tire";
            this.flattireCheck.UseVisualStyleBackColor = true;
            this.flattireCheck.CheckedChanged += new System.EventHandler(this.flattireCheck_CheckedChanged);
            // 
            // brakepadCheck
            // 
            this.brakepadCheck.AutoSize = true;
            this.brakepadCheck.Location = new System.Drawing.Point(7, 22);
            this.brakepadCheck.Name = "brakepadCheck";
            this.brakepadCheck.Size = new System.Drawing.Size(129, 21);
            this.brakepadCheck.TabIndex = 0;
            this.brakepadCheck.Text = "Brake pad wear";
            this.brakepadCheck.UseVisualStyleBackColor = true;
            this.brakepadCheck.CheckedChanged += new System.EventHandler(this.brakepadCheck_CheckedChanged);
            // 
            // featureGroup
            // 
            this.featureGroup.Controls.Add(this.brakepadGroup);
            this.featureGroup.Controls.Add(this.yawmomentCheck);
            this.featureGroup.Controls.Add(this.brakefadingCheck);
            this.featureGroup.Controls.Add(this.brakedryCheck);
            this.featureGroup.Controls.Add(this.softstopCheck);
            this.featureGroup.Controls.Add(this.rotationCheck);
            this.featureGroup.Controls.Add(this.activefrontCheck);
            this.featureGroup.Controls.Add(this.reductionCheck);
            this.featureGroup.Location = new System.Drawing.Point(250, 97);
            this.featureGroup.Name = "featureGroup";
            this.featureGroup.Size = new System.Drawing.Size(262, 268);
            this.featureGroup.TabIndex = 4;
            this.featureGroup.TabStop = false;
            this.featureGroup.Text = "Features";
            // 
            // brakepadGroup
            // 
            this.brakepadGroup.Controls.Add(this.brakepadrearCheck);
            this.brakepadGroup.Controls.Add(this.brakepadfrontCheck);
            this.brakepadGroup.Location = new System.Drawing.Point(7, 212);
            this.brakepadGroup.Name = "brakepadGroup";
            this.brakepadGroup.Size = new System.Drawing.Size(249, 47);
            this.brakepadGroup.TabIndex = 7;
            this.brakepadGroup.TabStop = false;
            this.brakepadGroup.Text = "Brake pad wear compensation";
            // 
            // brakepadrearCheck
            // 
            this.brakepadrearCheck.AutoSize = true;
            this.brakepadrearCheck.Location = new System.Drawing.Point(141, 21);
            this.brakepadrearCheck.Name = "brakepadrearCheck";
            this.brakepadrearCheck.Size = new System.Drawing.Size(61, 21);
            this.brakepadrearCheck.TabIndex = 9;
            this.brakepadrearCheck.Text = "Rear";
            this.brakepadrearCheck.UseVisualStyleBackColor = true;
            this.brakepadrearCheck.CheckedChanged += new System.EventHandler(this.brakepadrearCheck_CheckedChanged);
            // 
            // brakepadfrontCheck
            // 
            this.brakepadfrontCheck.AutoSize = true;
            this.brakepadfrontCheck.Location = new System.Drawing.Point(6, 21);
            this.brakepadfrontCheck.Name = "brakepadfrontCheck";
            this.brakepadfrontCheck.Size = new System.Drawing.Size(63, 21);
            this.brakepadfrontCheck.TabIndex = 8;
            this.brakepadfrontCheck.Text = "Front";
            this.brakepadfrontCheck.UseVisualStyleBackColor = true;
            this.brakepadfrontCheck.CheckedChanged += new System.EventHandler(this.brakepadfrontCheck_CheckedChanged);
            // 
            // yawmomentCheck
            // 
            this.yawmomentCheck.AutoSize = true;
            this.yawmomentCheck.Location = new System.Drawing.Point(7, 184);
            this.yawmomentCheck.Name = "yawmomentCheck";
            this.yawmomentCheck.Size = new System.Drawing.Size(202, 21);
            this.yawmomentCheck.TabIndex = 6;
            this.yawmomentCheck.Text = "Yaw moment compensation";
            this.yawmomentCheck.UseVisualStyleBackColor = true;
            this.yawmomentCheck.CheckedChanged += new System.EventHandler(this.yawmomentCheck_CheckedChanged);
            // 
            // brakefadingCheck
            // 
            this.brakefadingCheck.AutoSize = true;
            this.brakefadingCheck.Location = new System.Drawing.Point(7, 157);
            this.brakefadingCheck.Name = "brakefadingCheck";
            this.brakefadingCheck.Size = new System.Drawing.Size(202, 21);
            this.brakefadingCheck.TabIndex = 5;
            this.brakefadingCheck.Text = "Brake fading compensation";
            this.brakefadingCheck.UseVisualStyleBackColor = true;
            this.brakefadingCheck.CheckedChanged += new System.EventHandler(this.brakefadingCheck_CheckedChanged);
            // 
            // brakedryCheck
            // 
            this.brakedryCheck.AutoSize = true;
            this.brakedryCheck.Location = new System.Drawing.Point(7, 130);
            this.brakedryCheck.Name = "brakedryCheck";
            this.brakedryCheck.Size = new System.Drawing.Size(139, 21);
            this.brakedryCheck.TabIndex = 4;
            this.brakedryCheck.Text = "Brake disc drying";
            this.brakedryCheck.UseVisualStyleBackColor = true;
            this.brakedryCheck.CheckedChanged += new System.EventHandler(this.brakedryCheck_CheckedChanged);
            // 
            // softstopCheck
            // 
            this.softstopCheck.AutoSize = true;
            this.softstopCheck.Location = new System.Drawing.Point(7, 103);
            this.softstopCheck.Name = "softstopCheck";
            this.softstopCheck.Size = new System.Drawing.Size(87, 21);
            this.softstopCheck.TabIndex = 3;
            this.softstopCheck.Text = "Soft-stop";
            this.softstopCheck.UseVisualStyleBackColor = true;
            this.softstopCheck.CheckedChanged += new System.EventHandler(this.softstopCheck_CheckedChanged);
            // 
            // rotationCheck
            // 
            this.rotationCheck.AutoSize = true;
            this.rotationCheck.Location = new System.Drawing.Point(7, 76);
            this.rotationCheck.Name = "rotationCheck";
            this.rotationCheck.Size = new System.Drawing.Size(203, 21);
            this.rotationCheck.TabIndex = 2;
            this.rotationCheck.Text = "Rotation direction detection";
            this.rotationCheck.UseVisualStyleBackColor = true;
            this.rotationCheck.CheckedChanged += new System.EventHandler(this.rotationCheck_CheckedChanged);
            // 
            // activefrontCheck
            // 
            this.activefrontCheck.AutoSize = true;
            this.activefrontCheck.Location = new System.Drawing.Point(7, 49);
            this.activefrontCheck.Name = "activefrontCheck";
            this.activefrontCheck.Size = new System.Drawing.Size(156, 21);
            this.activefrontCheck.TabIndex = 1;
            this.activefrontCheck.Text = "Active front steering";
            this.activefrontCheck.UseVisualStyleBackColor = true;
            this.activefrontCheck.CheckedChanged += new System.EventHandler(this.activefrontCheck_CheckedChanged);
            // 
            // reductionCheck
            // 
            this.reductionCheck.AutoSize = true;
            this.reductionCheck.Location = new System.Drawing.Point(7, 22);
            this.reductionCheck.Name = "reductionCheck";
            this.reductionCheck.Size = new System.Drawing.Size(241, 21);
            this.reductionCheck.TabIndex = 0;
            this.reductionCheck.Text = "Reduce power on brake overheat";
            this.reductionCheck.UseVisualStyleBackColor = true;
            this.reductionCheck.CheckedChanged += new System.EventHandler(this.reductionCheck_CheckedChanged);
            // 
            // oversteerTrack
            // 
            this.oversteerTrack.Location = new System.Drawing.Point(9, 32);
            this.oversteerTrack.Maximum = 11;
            this.oversteerTrack.Name = "oversteerTrack";
            this.oversteerTrack.Size = new System.Drawing.Size(231, 56);
            this.oversteerTrack.TabIndex = 5;
            this.oversteerTrack.Scroll += new System.EventHandler(this.oversteerTrack_Scroll);
            // 
            // oversteerLabel
            // 
            this.oversteerLabel.AutoSize = true;
            this.oversteerLabel.Location = new System.Drawing.Point(9, 12);
            this.oversteerLabel.Name = "oversteerLabel";
            this.oversteerLabel.Size = new System.Drawing.Size(182, 17);
            this.oversteerLabel.TabIndex = 6;
            this.oversteerLabel.Text = "Oversteer friction sensitivity";
            // 
            // oversteerlowLabel
            // 
            this.oversteerlowLabel.AutoSize = true;
            this.oversteerlowLabel.Location = new System.Drawing.Point(9, 62);
            this.oversteerlowLabel.Name = "oversteerlowLabel";
            this.oversteerlowLabel.Size = new System.Drawing.Size(33, 17);
            this.oversteerlowLabel.TabIndex = 7;
            this.oversteerlowLabel.Text = "Low";
            // 
            // oversteerhighLabel
            // 
            this.oversteerhighLabel.AutoSize = true;
            this.oversteerhighLabel.Location = new System.Drawing.Point(203, 62);
            this.oversteerhighLabel.Name = "oversteerhighLabel";
            this.oversteerhighLabel.Size = new System.Drawing.Size(37, 17);
            this.oversteerhighLabel.TabIndex = 8;
            this.oversteerhighLabel.Text = "High";
            // 
            // understeerLabel
            // 
            this.understeerLabel.AutoSize = true;
            this.understeerLabel.Location = new System.Drawing.Point(9, 83);
            this.understeerLabel.Name = "understeerLabel";
            this.understeerLabel.Size = new System.Drawing.Size(231, 17);
            this.understeerLabel.TabIndex = 9;
            this.understeerLabel.Text = "Understeer friction threshold option";
            // 
            // understeerTrack
            // 
            this.understeerTrack.Location = new System.Drawing.Point(9, 103);
            this.understeerTrack.Maximum = 3;
            this.understeerTrack.Name = "understeerTrack";
            this.understeerTrack.Size = new System.Drawing.Size(231, 56);
            this.understeerTrack.TabIndex = 10;
            this.understeerTrack.Scroll += new System.EventHandler(this.understeerTrack_Scroll);
            // 
            // deltapsiLabel
            // 
            this.deltapsiLabel.AutoSize = true;
            this.deltapsiLabel.Location = new System.Drawing.Point(9, 138);
            this.deltapsiLabel.Name = "deltapsiLabel";
            this.deltapsiLabel.Size = new System.Drawing.Size(207, 17);
            this.deltapsiLabel.TabIndex = 11;
            this.deltapsiLabel.Text = "Delta-psi-beta correction option";
            // 
            // deltapsiTrack
            // 
            this.deltapsiTrack.Location = new System.Drawing.Point(9, 159);
            this.deltapsiTrack.Maximum = 3;
            this.deltapsiTrack.Name = "deltapsiTrack";
            this.deltapsiTrack.Size = new System.Drawing.Size(231, 56);
            this.deltapsiTrack.TabIndex = 12;
            this.deltapsiTrack.Scroll += new System.EventHandler(this.deltapsiTrack_Scroll);
            // 
            // anglecurveLabel
            // 
            this.anglecurveLabel.AutoSize = true;
            this.anglecurveLabel.Location = new System.Drawing.Point(9, 198);
            this.anglecurveLabel.Name = "anglecurveLabel";
            this.anglecurveLabel.Size = new System.Drawing.Size(182, 17);
            this.anglecurveLabel.TabIndex = 13;
            this.anglecurveLabel.Text = "Steering angle curve option";
            // 
            // anglecurveTrack
            // 
            this.anglecurveTrack.Location = new System.Drawing.Point(9, 221);
            this.anglecurveTrack.Maximum = 3;
            this.anglecurveTrack.Name = "anglecurveTrack";
            this.anglecurveTrack.Size = new System.Drawing.Size(231, 56);
            this.anglecurveTrack.TabIndex = 14;
            this.anglecurveTrack.Scroll += new System.EventHandler(this.anglecurveTrack_Scroll);
            // 
            // startoffLabel
            // 
            this.startoffLabel.AutoSize = true;
            this.startoffLabel.Location = new System.Drawing.Point(9, 258);
            this.startoffLabel.Name = "startoffLabel";
            this.startoffLabel.Size = new System.Drawing.Size(162, 17);
            this.startoffLabel.TabIndex = 15;
            this.startoffLabel.Text = "Start-off assistant option";
            // 
            // startoffTrack
            // 
            this.startoffTrack.Location = new System.Drawing.Point(12, 278);
            this.startoffTrack.Maximum = 6;
            this.startoffTrack.Name = "startoffTrack";
            this.startoffTrack.Size = new System.Drawing.Size(231, 56);
            this.startoffTrack.TabIndex = 16;
            this.startoffTrack.Scroll += new System.EventHandler(this.startoffTrack_Scroll);
            // 
            // startoffoffLabel
            // 
            this.startoffoffLabel.AutoSize = true;
            this.startoffoffLabel.Location = new System.Drawing.Point(12, 309);
            this.startoffoffLabel.Name = "startoffoffLabel";
            this.startoffoffLabel.Size = new System.Drawing.Size(27, 17);
            this.startoffoffLabel.TabIndex = 17;
            this.startoffoffLabel.Text = "Off";
            // 
            // yawmomentGroup
            // 
            this.yawmomentGroup.Controls.Add(this.yawmomentLargeLabel);
            this.yawmomentGroup.Controls.Add(this.yawmoment0Label);
            this.yawmomentGroup.Controls.Add(this.yawmomentrearTrack);
            this.yawmomentGroup.Controls.Add(this.yawmomwntrearLabel);
            this.yawmomentGroup.Controls.Add(this.yawmomentfrontTrack);
            this.yawmomentGroup.Controls.Add(this.yawmomentfrontLabel);
            this.yawmomentGroup.Location = new System.Drawing.Point(12, 329);
            this.yawmomentGroup.Name = "yawmomentGroup";
            this.yawmomentGroup.Size = new System.Drawing.Size(228, 118);
            this.yawmomentGroup.TabIndex = 18;
            this.yawmomentGroup.TabStop = false;
            this.yawmomentGroup.Text = "Yaw moment friction radius";
            // 
            // yawmomentLargeLabel
            // 
            this.yawmomentLargeLabel.AutoSize = true;
            this.yawmomentLargeLabel.Location = new System.Drawing.Point(177, 92);
            this.yawmomentLargeLabel.Name = "yawmomentLargeLabel";
            this.yawmomentLargeLabel.Size = new System.Drawing.Size(45, 17);
            this.yawmomentLargeLabel.TabIndex = 22;
            this.yawmomentLargeLabel.Text = "Large";
            // 
            // yawmoment0Label
            // 
            this.yawmoment0Label.AutoSize = true;
            this.yawmoment0Label.Location = new System.Drawing.Point(53, 92);
            this.yawmoment0Label.Name = "yawmoment0Label";
            this.yawmoment0Label.Size = new System.Drawing.Size(16, 17);
            this.yawmoment0Label.TabIndex = 21;
            this.yawmoment0Label.Text = "0";
            // 
            // yawmomentrearTrack
            // 
            this.yawmomentrearTrack.Location = new System.Drawing.Point(44, 53);
            this.yawmomentrearTrack.Maximum = 5;
            this.yawmomentrearTrack.Name = "yawmomentrearTrack";
            this.yawmomentrearTrack.Size = new System.Drawing.Size(178, 56);
            this.yawmomentrearTrack.TabIndex = 20;
            this.yawmomentrearTrack.Scroll += new System.EventHandler(this.yawmomentrearTrack_Scroll);
            // 
            // yawmomwntrearLabel
            // 
            this.yawmomwntrearLabel.AutoSize = true;
            this.yawmomwntrearLabel.Location = new System.Drawing.Point(8, 53);
            this.yawmomwntrearLabel.Name = "yawmomwntrearLabel";
            this.yawmomwntrearLabel.Size = new System.Drawing.Size(39, 17);
            this.yawmomwntrearLabel.TabIndex = 20;
            this.yawmomwntrearLabel.Text = "Rear";
            // 
            // yawmomentfrontTrack
            // 
            this.yawmomentfrontTrack.Location = new System.Drawing.Point(44, 18);
            this.yawmomentfrontTrack.Maximum = 5;
            this.yawmomentfrontTrack.Name = "yawmomentfrontTrack";
            this.yawmomentfrontTrack.Size = new System.Drawing.Size(178, 56);
            this.yawmomentfrontTrack.TabIndex = 19;
            this.yawmomentfrontTrack.Scroll += new System.EventHandler(this.yawmomentfrontTrack_Scroll);
            // 
            // yawmomentfrontLabel
            // 
            this.yawmomentfrontLabel.AutoSize = true;
            this.yawmomentfrontLabel.Location = new System.Drawing.Point(6, 19);
            this.yawmomentfrontLabel.Name = "yawmomentfrontLabel";
            this.yawmomentfrontLabel.Size = new System.Drawing.Size(41, 17);
            this.yawmomentfrontLabel.TabIndex = 19;
            this.yawmomentfrontLabel.Text = "Front";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(9, 454);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(340, 17);
            this.creditsLabel.TabIndex = 19;
            this.creditsLabel.Text = "2022 KTU. For educational purposes only. 220511r2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 520);
            this.ControlBox = false;
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.yawmomentGroup);
            this.Controls.Add(this.startoffoffLabel);
            this.Controls.Add(this.startoffTrack);
            this.Controls.Add(this.startoffLabel);
            this.Controls.Add(this.anglecurveTrack);
            this.Controls.Add(this.anglecurveLabel);
            this.Controls.Add(this.deltapsiTrack);
            this.Controls.Add(this.deltapsiLabel);
            this.Controls.Add(this.understeerTrack);
            this.Controls.Add(this.understeerLabel);
            this.Controls.Add(this.oversteerhighLabel);
            this.Controls.Add(this.oversteerlowLabel);
            this.Controls.Add(this.oversteerLabel);
            this.Controls.Add(this.oversteerTrack);
            this.Controls.Add(this.featureGroup);
            this.Controls.Add(this.indicatorGroup);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.importButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BMW ABS Module Tweaker";
            this.indicatorGroup.ResumeLayout(false);
            this.indicatorGroup.PerformLayout();
            this.featureGroup.ResumeLayout(false);
            this.featureGroup.PerformLayout();
            this.brakepadGroup.ResumeLayout(false);
            this.brakepadGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oversteerTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.understeerTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltapsiTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anglecurveTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startoffTrack)).EndInit();
            this.yawmomentGroup.ResumeLayout(false);
            this.yawmomentGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yawmomentrearTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawmomentfrontTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox indicatorGroup;
        private System.Windows.Forms.CheckBox flattireCheck;
        private System.Windows.Forms.CheckBox brakepadCheck;
        private System.Windows.Forms.GroupBox featureGroup;
        private System.Windows.Forms.CheckBox activefrontCheck;
        private System.Windows.Forms.CheckBox reductionCheck;
        private System.Windows.Forms.TrackBar oversteerTrack;
        private System.Windows.Forms.CheckBox softstopCheck;
        private System.Windows.Forms.CheckBox rotationCheck;
        private System.Windows.Forms.GroupBox brakepadGroup;
        private System.Windows.Forms.CheckBox brakepadrearCheck;
        private System.Windows.Forms.CheckBox brakepadfrontCheck;
        private System.Windows.Forms.CheckBox yawmomentCheck;
        private System.Windows.Forms.CheckBox brakefadingCheck;
        private System.Windows.Forms.CheckBox brakedryCheck;
        private System.Windows.Forms.Label oversteerLabel;
        private System.Windows.Forms.Label oversteerlowLabel;
        private System.Windows.Forms.Label oversteerhighLabel;
        private System.Windows.Forms.Label understeerLabel;
        private System.Windows.Forms.TrackBar understeerTrack;
        private System.Windows.Forms.Label deltapsiLabel;
        private System.Windows.Forms.TrackBar deltapsiTrack;
        private System.Windows.Forms.Label anglecurveLabel;
        private System.Windows.Forms.TrackBar anglecurveTrack;
        private System.Windows.Forms.Label startoffLabel;
        private System.Windows.Forms.TrackBar startoffTrack;
        private System.Windows.Forms.Label startoffoffLabel;
        private System.Windows.Forms.GroupBox yawmomentGroup;
        private System.Windows.Forms.Label yawmomentfrontLabel;
        private System.Windows.Forms.Label yawmoment0Label;
        private System.Windows.Forms.TrackBar yawmomentrearTrack;
        private System.Windows.Forms.Label yawmomwntrearLabel;
        private System.Windows.Forms.TrackBar yawmomentfrontTrack;
        private System.Windows.Forms.Label yawmomentLargeLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label creditsLabel;
    }
}

