namespace Mahjong
{
    partial class NewGameForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.heightTBar = new System.Windows.Forms.TrackBar();
            this.widthCountLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthCountLabel = new System.Windows.Forms.Label();
            this.widthTBar = new System.Windows.Forms.TrackBar();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightCountLabel = new System.Windows.Forms.Label();
            this.lengthTBar = new System.Windows.Forms.TrackBar();
            this.fieldSizePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.easyRButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hardRButton = new System.Windows.Forms.RadioButton();
            this.standartRButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pyramidRButton = new System.Windows.Forms.RadioButton();
            this.rectangleRButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heightTBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTBar)).BeginInit();
            this.fieldSizePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Размер поля:";
            // 
            // heightTBar
            // 
            this.heightTBar.Location = new System.Drawing.Point(96, 105);
            this.heightTBar.Maximum = 7;
            this.heightTBar.Minimum = 1;
            this.heightTBar.Name = "heightTBar";
            this.heightTBar.Size = new System.Drawing.Size(104, 45);
            this.heightTBar.TabIndex = 1;
            this.heightTBar.Tag = "3";
            this.heightTBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.heightTBar.Value = 2;
            this.heightTBar.Scroll += new System.EventHandler(this.TBar_Scroll);
            // 
            // widthCountLabel
            // 
            this.widthCountLabel.AutoSize = true;
            this.widthCountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthCountLabel.Location = new System.Drawing.Point(206, 24);
            this.widthCountLabel.Name = "widthCountLabel";
            this.widthCountLabel.Size = new System.Drawing.Size(74, 19);
            this.widthCountLabel.TabIndex = 2;
            this.widthCountLabel.Tag = "1";
            this.widthCountLabel.Text = "10 костей";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.Location = new System.Drawing.Point(24, 24);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(70, 19);
            this.widthLabel.TabIndex = 7;
            this.widthLabel.Text = "Ширина:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthLabel.Location = new System.Drawing.Point(24, 64);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(57, 19);
            this.lengthLabel.TabIndex = 10;
            this.lengthLabel.Text = "Длина:";
            // 
            // lengthCountLabel
            // 
            this.lengthCountLabel.AutoSize = true;
            this.lengthCountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthCountLabel.Location = new System.Drawing.Point(206, 64);
            this.lengthCountLabel.Name = "lengthCountLabel";
            this.lengthCountLabel.Size = new System.Drawing.Size(66, 19);
            this.lengthCountLabel.TabIndex = 9;
            this.lengthCountLabel.Tag = "2";
            this.lengthCountLabel.Text = "6 костей";
            // 
            // widthTBar
            // 
            this.widthTBar.Location = new System.Drawing.Point(96, 24);
            this.widthTBar.Minimum = 1;
            this.widthTBar.Name = "widthTBar";
            this.widthTBar.Size = new System.Drawing.Size(104, 45);
            this.widthTBar.TabIndex = 8;
            this.widthTBar.Tag = "1";
            this.widthTBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.widthTBar.Value = 5;
            this.widthTBar.Scroll += new System.EventHandler(this.TBar_Scroll);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(24, 105);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(62, 19);
            this.heightLabel.TabIndex = 13;
            this.heightLabel.Text = "Высота:";
            // 
            // heightCountLabel
            // 
            this.heightCountLabel.AutoSize = true;
            this.heightCountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightCountLabel.Location = new System.Drawing.Point(206, 105);
            this.heightCountLabel.Name = "heightCountLabel";
            this.heightCountLabel.Size = new System.Drawing.Size(58, 19);
            this.heightCountLabel.TabIndex = 12;
            this.heightCountLabel.Tag = "3";
            this.heightCountLabel.Text = "2 кости";
            // 
            // lengthTBar
            // 
            this.lengthTBar.Location = new System.Drawing.Point(96, 64);
            this.lengthTBar.Maximum = 20;
            this.lengthTBar.Minimum = 1;
            this.lengthTBar.Name = "lengthTBar";
            this.lengthTBar.Size = new System.Drawing.Size(104, 45);
            this.lengthTBar.TabIndex = 11;
            this.lengthTBar.Tag = "2";
            this.lengthTBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.lengthTBar.Value = 6;
            this.lengthTBar.Scroll += new System.EventHandler(this.TBar_Scroll);
            // 
            // fieldSizePanel
            // 
            this.fieldSizePanel.BackColor = System.Drawing.Color.White;
            this.fieldSizePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldSizePanel.Controls.Add(this.heightLabel);
            this.fieldSizePanel.Controls.Add(this.heightTBar);
            this.fieldSizePanel.Controls.Add(this.heightCountLabel);
            this.fieldSizePanel.Controls.Add(this.widthCountLabel);
            this.fieldSizePanel.Controls.Add(this.lengthTBar);
            this.fieldSizePanel.Controls.Add(this.widthLabel);
            this.fieldSizePanel.Controls.Add(this.lengthLabel);
            this.fieldSizePanel.Controls.Add(this.widthTBar);
            this.fieldSizePanel.Controls.Add(this.lengthCountLabel);
            this.fieldSizePanel.Location = new System.Drawing.Point(12, 119);
            this.fieldSizePanel.Name = "fieldSizePanel";
            this.fieldSizePanel.Size = new System.Drawing.Size(297, 154);
            this.fieldSizePanel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сложность:";
            // 
            // easyRButton
            // 
            this.easyRButton.AutoSize = true;
            this.easyRButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.easyRButton.Location = new System.Drawing.Point(13, 13);
            this.easyRButton.Name = "easyRButton";
            this.easyRButton.Size = new System.Drawing.Size(66, 23);
            this.easyRButton.TabIndex = 16;
            this.easyRButton.TabStop = true;
            this.easyRButton.Text = "Легко";
            this.easyRButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.hardRButton);
            this.panel2.Controls.Add(this.standartRButton);
            this.panel2.Controls.Add(this.easyRButton);
            this.panel2.Location = new System.Drawing.Point(12, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 53);
            this.panel2.TabIndex = 17;
            // 
            // hardRButton
            // 
            this.hardRButton.AutoSize = true;
            this.hardRButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardRButton.Location = new System.Drawing.Point(206, 13);
            this.hardRButton.Name = "hardRButton";
            this.hardRButton.Size = new System.Drawing.Size(74, 23);
            this.hardRButton.TabIndex = 18;
            this.hardRButton.TabStop = true;
            this.hardRButton.Text = "Трудно";
            this.hardRButton.UseVisualStyleBackColor = true;
            // 
            // standartRButton
            // 
            this.standartRButton.AutoSize = true;
            this.standartRButton.Checked = true;
            this.standartRButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.standartRButton.Location = new System.Drawing.Point(104, 13);
            this.standartRButton.Name = "standartRButton";
            this.standartRButton.Size = new System.Drawing.Size(78, 23);
            this.standartRButton.TabIndex = 17;
            this.standartRButton.TabStop = true;
            this.standartRButton.Text = "Средне";
            this.standartRButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип поля:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pyramidRButton);
            this.panel3.Controls.Add(this.rectangleRButton);
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 53);
            this.panel3.TabIndex = 19;
            // 
            // pyramidRButton
            // 
            this.pyramidRButton.AutoSize = true;
            this.pyramidRButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pyramidRButton.Location = new System.Drawing.Point(181, 14);
            this.pyramidRButton.Name = "pyramidRButton";
            this.pyramidRButton.Size = new System.Drawing.Size(99, 23);
            this.pyramidRButton.TabIndex = 17;
            this.pyramidRButton.TabStop = true;
            this.pyramidRButton.Tag = "4";
            this.pyramidRButton.Text = "Пирамида";
            this.pyramidRButton.UseVisualStyleBackColor = true;
            // 
            // rectangleRButton
            // 
            this.rectangleRButton.AutoSize = true;
            this.rectangleRButton.Checked = true;
            this.rectangleRButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rectangleRButton.Location = new System.Drawing.Point(13, 14);
            this.rectangleRButton.Name = "rectangleRButton";
            this.rectangleRButton.Size = new System.Drawing.Size(134, 23);
            this.rectangleRButton.TabIndex = 16;
            this.rectangleRButton.TabStop = true;
            this.rectangleRButton.Text = "Прямоугольник";
            this.rectangleRButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(95, 389);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 31);
            this.startButton.TabIndex = 20;
            this.startButton.Text = "Новая игра";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(328, 432);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldSizePanel);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая игра";
            ((System.ComponentModel.ISupportInitialize)(this.heightTBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthTBar)).EndInit();
            this.fieldSizePanel.ResumeLayout(false);
            this.fieldSizePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar heightTBar;
        private System.Windows.Forms.Label widthCountLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label lengthCountLabel;
        private System.Windows.Forms.TrackBar widthTBar;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label heightCountLabel;
        private System.Windows.Forms.TrackBar lengthTBar;
        private System.Windows.Forms.Panel fieldSizePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton easyRButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton hardRButton;
        private System.Windows.Forms.RadioButton standartRButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton pyramidRButton;
        private System.Windows.Forms.RadioButton rectangleRButton;
        private System.Windows.Forms.Button startButton;
    }
}