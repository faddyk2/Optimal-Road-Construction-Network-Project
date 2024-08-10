namespace primOCR
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
            pointA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pointB = new TextBox();
            obstacles = new GroupBox();
            checkBox5 = new CheckBox();
            forest = new CheckBox();
            res = new CheckBox();
            river = new CheckBox();
            mountain = new CheckBox();
            distanceBox = new TextBox();
            label3 = new Label();
            closeButton = new Button();
            goBack = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            thisCostlbl = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            totalCostlbl = new Label();
            totalConnection = new Label();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            connectiontxt = new RichTextBox();
            groupBox3 = new GroupBox();
            connectionsPanel = new Panel();
            button4 = new Button();
            groupBox4 = new GroupBox();
            primsVisual = new Panel();
            primsConnections = new RichTextBox();
            groupBox5 = new GroupBox();
            removed = new Panel();
            primsCost = new Label();
            obstacles.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // pointA
            // 
            pointA.Location = new Point(99, 165);
            pointA.Name = "pointA";
            pointA.Size = new Size(212, 23);
            pointA.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 168);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Point A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 228);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Point B";
            // 
            // pointB
            // 
            pointB.Location = new Point(99, 225);
            pointB.Name = "pointB";
            pointB.Size = new Size(212, 23);
            pointB.TabIndex = 2;
            // 
            // obstacles
            // 
            obstacles.Controls.Add(checkBox5);
            obstacles.Controls.Add(forest);
            obstacles.Controls.Add(res);
            obstacles.Controls.Add(river);
            obstacles.Controls.Add(mountain);
            obstacles.Location = new Point(35, 304);
            obstacles.Name = "obstacles";
            obstacles.Size = new Size(434, 208);
            obstacles.TabIndex = 4;
            obstacles.TabStop = false;
            obstacles.Text = "Obstacles and Hindrances";
            obstacles.Enter += obstacles_Enter;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(223, 34);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(56, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Other";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // forest
            // 
            forest.AutoSize = true;
            forest.Location = new Point(15, 170);
            forest.Name = "forest";
            forest.Size = new Size(150, 19);
            forest.TabIndex = 3;
            forest.Text = "Forests / wood cuttings";
            forest.UseVisualStyleBackColor = true;
            forest.CheckedChanged += forest_CheckedChanged;
            // 
            // res
            // 
            res.AutoSize = true;
            res.Location = new Point(15, 123);
            res.Name = "res";
            res.Size = new Size(148, 19);
            res.TabIndex = 2;
            res.Text = "Residence / Civilization";
            res.UseVisualStyleBackColor = true;
            res.CheckedChanged += res_CheckedChanged;
            // 
            // river
            // 
            river.AutoSize = true;
            river.Location = new Point(15, 77);
            river.Name = "river";
            river.Size = new Size(202, 19);
            river.TabIndex = 1;
            river.Text = "River Crossings / Water Crossings";
            river.UseVisualStyleBackColor = true;
            river.CheckedChanged += river_CheckedChanged;
            // 
            // mountain
            // 
            mountain.AutoSize = true;
            mountain.Location = new Point(15, 34);
            mountain.Name = "mountain";
            mountain.Size = new Size(76, 19);
            mountain.TabIndex = 0;
            mountain.Text = "Moutains";
            mountain.UseVisualStyleBackColor = true;
            mountain.CheckedChanged += mountain_CheckedChanged;
            // 
            // distanceBox
            // 
            distanceBox.Location = new Point(383, 165);
            distanceBox.Name = "distanceBox";
            distanceBox.Size = new Size(86, 23);
            distanceBox.TabIndex = 5;
            distanceBox.TextChanged += distanceBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 168);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Distance";
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.Control;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.IndianRed;
            closeButton.Location = new Point(1185, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(87, 42);
            closeButton.TabIndex = 7;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // goBack
            // 
            goBack.Location = new Point(89, 516);
            goBack.Name = "goBack";
            goBack.Size = new Size(276, 58);
            goBack.TabIndex = 9;
            goBack.Text = "Remove Last Vertex";
            goBack.UseVisualStyleBackColor = true;
            goBack.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(thisCostlbl);
            groupBox2.Controls.Add(goBack);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(22, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(484, 661);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Connections Controls";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(372, 122);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "TestButton";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 62);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 16;
            label5.Text = "KM";
            // 
            // thisCostlbl
            // 
            thisCostlbl.AutoSize = true;
            thisCostlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            thisCostlbl.Location = new Point(6, 610);
            thisCostlbl.Name = "thisCostlbl";
            thisCostlbl.Size = new Size(204, 25);
            thisCostlbl.TabIndex = 13;
            thisCostlbl.Text = "This Connection Cost : ";
            // 
            // button1
            // 
            button1.Location = new Point(89, 438);
            button1.Name = "button1";
            button1.Size = new Size(276, 60);
            button1.TabIndex = 8;
            button1.Text = "Create Connection";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(closeButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 74);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(325, 9);
            label4.Name = "label4";
            label4.Size = new Size(685, 50);
            label4.TabIndex = 13;
            label4.Text = "Optimal Road Construction (Network)";
            // 
            // totalCostlbl
            // 
            totalCostlbl.AutoSize = true;
            totalCostlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalCostlbl.Location = new Point(25, 900);
            totalCostlbl.Name = "totalCostlbl";
            totalCostlbl.Size = new Size(108, 25);
            totalCostlbl.TabIndex = 14;
            totalCostlbl.Text = "Total Cost : ";
            // 
            // totalConnection
            // 
            totalConnection.AutoSize = true;
            totalConnection.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalConnection.Location = new Point(25, 827);
            totalConnection.Name = "totalConnection";
            totalConnection.Size = new Size(186, 25);
            totalConnection.TabIndex = 15;
            totalConnection.Text = "Total Connections : 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(connectiontxt);
            groupBox1.Location = new Point(523, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 421);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connections";
            // 
            // panel2
            // 
            panel2.Location = new Point(372, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 393);
            panel2.TabIndex = 18;
            // 
            // connectiontxt
            // 
            connectiontxt.Location = new Point(6, 22);
            connectiontxt.Name = "connectiontxt";
            connectiontxt.ReadOnly = true;
            connectiontxt.Size = new Size(332, 384);
            connectiontxt.TabIndex = 0;
            connectiontxt.Text = "";
            connectiontxt.TextChanged += connectiontxt_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(connectionsPanel);
            groupBox3.Location = new Point(895, 84);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(345, 421);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Connections (visual)";
            // 
            // connectionsPanel
            // 
            connectionsPanel.BackColor = SystemColors.ButtonHighlight;
            connectionsPanel.ForeColor = SystemColors.ButtonHighlight;
            connectionsPanel.Location = new Point(6, 22);
            connectionsPanel.Name = "connectionsPanel";
            connectionsPanel.Size = new Size(330, 384);
            connectionsPanel.TabIndex = 0;
            connectionsPanel.Paint += connectionsPanel_Paint;
            // 
            // button4
            // 
            button4.Location = new Point(747, 511);
            button4.Name = "button4";
            button4.Size = new Size(276, 31);
            button4.TabIndex = 18;
            button4.Text = "Find the Best Solution / Apply Prims";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(primsVisual);
            groupBox4.Controls.Add(primsConnections);
            groupBox4.Location = new Point(523, 548);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(741, 392);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Connections After Prims Algorithm";
            // 
            // primsVisual
            // 
            primsVisual.BackColor = SystemColors.ButtonHighlight;
            primsVisual.ForeColor = SystemColors.ButtonHighlight;
            primsVisual.Location = new Point(17, 34);
            primsVisual.Name = "primsVisual";
            primsVisual.Size = new Size(321, 333);
            primsVisual.TabIndex = 1;
            primsVisual.Paint += primsVisual_Paint_1;
            // 
            // primsConnections
            // 
            primsConnections.Location = new Point(6, 22);
            primsConnections.Name = "primsConnections";
            primsConnections.ReadOnly = true;
            primsConnections.Size = new Size(345, 355);
            primsConnections.TabIndex = 0;
            primsConnections.Text = "";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(removed);
            groupBox5.Location = new Point(895, 548);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(351, 377);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Removed Connections";
            // 
            // removed
            // 
            removed.BackColor = SystemColors.ButtonHighlight;
            removed.ForeColor = SystemColors.ButtonHighlight;
            removed.Location = new Point(17, 22);
            removed.Name = "removed";
            removed.Size = new Size(322, 336);
            removed.TabIndex = 0;
            removed.Paint += primsVisual_Paint;
            // 
            // primsCost
            // 
            primsCost.AutoSize = true;
            primsCost.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            primsCost.Location = new Point(523, 959);
            primsCost.Name = "primsCost";
            primsCost.Size = new Size(206, 25);
            primsCost.TabIndex = 20;
            primsCost.Text = "Total Cost After Prims : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 1044);
            Controls.Add(primsCost);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(totalConnection);
            Controls.Add(totalCostlbl);
            Controls.Add(label3);
            Controls.Add(distanceBox);
            Controls.Add(obstacles);
            Controls.Add(label2);
            Controls.Add(pointB);
            Controls.Add(label1);
            Controls.Add(pointA);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            obstacles.ResumeLayout(false);
            obstacles.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pointA;
        private Label label1;
        private Label label2;
        private TextBox pointB;
        private GroupBox obstacles;
        private TextBox distanceBox;
        private Label label3;
        private Button closeButton;
        private CheckBox checkBox5;
        private CheckBox forest;
        private CheckBox res;
        private CheckBox river;
        private CheckBox mountain;
        private Button goBack;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label4;
        private Label thisCostlbl;
        private Label totalCostlbl;
        private Button button1;
        private Label totalConnection;
        private Label label5;
        private GroupBox groupBox1;
        private RichTextBox connectiontxt;
        private Panel panel2;
        private GroupBox groupBox3;
        private Panel connectionsPanel;
        private Button button4;
        private GroupBox groupBox4;
        private RichTextBox primsConnections;
        private GroupBox groupBox5;
        private Panel removed;
        private Label primsCost;
        private Panel primsVisual;
        private Button button2;
    }
}