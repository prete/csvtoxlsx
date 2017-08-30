namespace CSVaXLS
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonFindFile = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFileDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxRemoveTextQualifier = new System.Windows.Forms.CheckBox();
            this.textBoxTextQualifier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDelimiter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxFirstRowHasColumnNames = new System.Windows.Forms.CheckBox();
            this.numericUpDownMaxRecordsPerFile = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomOutputName = new System.Windows.Forms.TextBox();
            this.checkBoxCustomOutputName = new System.Windows.Forms.CheckBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRecordsPerFile)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Todos|*.*|CSV|*.csv|TSV|*.tsv|TXT|*.txt";
            // 
            // buttonFindFile
            // 
            this.buttonFindFile.Location = new System.Drawing.Point(13, 13);
            this.buttonFindFile.Name = "buttonFindFile";
            this.buttonFindFile.Size = new System.Drawing.Size(75, 23);
            this.buttonFindFile.TabIndex = 0;
            this.buttonFindFile.Text = "Examinar";
            this.buttonFindFile.UseVisualStyleBackColor = true;
            this.buttonFindFile.Click += new System.EventHandler(this.buttonFindFile_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(116, 15);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(320, 20);
            this.textBoxFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(71, 18);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(0, 13);
            this.labelFileName.TabIndex = 4;
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(71, 40);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(0, 13);
            this.labelFileSize.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelFileDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelFileSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelFileName);
            this.groupBox1.Location = new System.Drawing.Point(436, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades del archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha:";
            // 
            // labelFileDate
            // 
            this.labelFileDate.AutoSize = true;
            this.labelFileDate.Location = new System.Drawing.Point(71, 66);
            this.labelFileDate.Name = "labelFileDate";
            this.labelFileDate.Size = new System.Drawing.Size(0, 13);
            this.labelFileDate.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxRemoveTextQualifier);
            this.groupBox2.Controls.Add(this.textBoxTextQualifier);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDelimiter);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkBoxFirstRowHasColumnNames);
            this.groupBox2.Controls.Add(this.numericUpDownMaxRecordsPerFile);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxCustomOutputName);
            this.groupBox2.Controls.Add(this.checkBoxCustomOutputName);
            this.groupBox2.Location = new System.Drawing.Point(13, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 187);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones de conversión";
            // 
            // checkBoxRemoveTextQualifier
            // 
            this.checkBoxRemoveTextQualifier.AutoSize = true;
            this.checkBoxRemoveTextQualifier.Location = new System.Drawing.Point(202, 122);
            this.checkBoxRemoveTextQualifier.Name = "checkBoxRemoveTextQualifier";
            this.checkBoxRemoveTextQualifier.Size = new System.Drawing.Size(120, 17);
            this.checkBoxRemoveTextQualifier.TabIndex = 10;
            this.checkBoxRemoveTextQualifier.Text = "Remover calificador";
            this.checkBoxRemoveTextQualifier.UseVisualStyleBackColor = true;
            // 
            // textBoxTextQualifier
            // 
            this.textBoxTextQualifier.Location = new System.Drawing.Point(202, 96);
            this.textBoxTextQualifier.MaxLength = 1;
            this.textBoxTextQualifier.Name = "textBoxTextQualifier";
            this.textBoxTextQualifier.Size = new System.Drawing.Size(128, 20);
            this.textBoxTextQualifier.TabIndex = 9;
            this.textBoxTextQualifier.Text = "\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Calificador de texto:";
            // 
            // textBoxDelimiter
            // 
            this.textBoxDelimiter.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDelimiter.Location = new System.Drawing.Point(202, 66);
            this.textBoxDelimiter.MaxLength = 1;
            this.textBoxDelimiter.Name = "textBoxDelimiter";
            this.textBoxDelimiter.Size = new System.Drawing.Size(128, 20);
            this.textBoxDelimiter.TabIndex = 7;
            this.textBoxDelimiter.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Separador:";
            // 
            // checkBoxFirstRowHasColumnNames
            // 
            this.checkBoxFirstRowHasColumnNames.AutoSize = true;
            this.checkBoxFirstRowHasColumnNames.Checked = true;
            this.checkBoxFirstRowHasColumnNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFirstRowHasColumnNames.Location = new System.Drawing.Point(6, 155);
            this.checkBoxFirstRowHasColumnNames.Name = "checkBoxFirstRowHasColumnNames";
            this.checkBoxFirstRowHasColumnNames.Size = new System.Drawing.Size(306, 17);
            this.checkBoxFirstRowHasColumnNames.TabIndex = 5;
            this.checkBoxFirstRowHasColumnNames.Text = "La primer fila del archivo contiene los nombres de columnas";
            this.checkBoxFirstRowHasColumnNames.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxRecordsPerFile
            // 
            this.numericUpDownMaxRecordsPerFile.Location = new System.Drawing.Point(202, 38);
            this.numericUpDownMaxRecordsPerFile.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownMaxRecordsPerFile.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxRecordsPerFile.Name = "numericUpDownMaxRecordsPerFile";
            this.numericUpDownMaxRecordsPerFile.Size = new System.Drawing.Size(128, 20);
            this.numericUpDownMaxRecordsPerFile.TabIndex = 4;
            this.numericUpDownMaxRecordsPerFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMaxRecordsPerFile.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad máx. de registros por archivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = ".xlsx";
            // 
            // textBoxCustomOutputName
            // 
            this.textBoxCustomOutputName.Enabled = false;
            this.textBoxCustomOutputName.Location = new System.Drawing.Point(202, 15);
            this.textBoxCustomOutputName.Name = "textBoxCustomOutputName";
            this.textBoxCustomOutputName.Size = new System.Drawing.Size(128, 20);
            this.textBoxCustomOutputName.TabIndex = 1;
            // 
            // checkBoxCustomOutputName
            // 
            this.checkBoxCustomOutputName.AutoSize = true;
            this.checkBoxCustomOutputName.Location = new System.Drawing.Point(6, 17);
            this.checkBoxCustomOutputName.Name = "checkBoxCustomOutputName";
            this.checkBoxCustomOutputName.Size = new System.Drawing.Size(166, 17);
            this.checkBoxCustomOutputName.TabIndex = 0;
            this.checkBoxCustomOutputName.Text = "Personalizar archivo de salida";
            this.checkBoxCustomOutputName.UseVisualStyleBackColor = true;
            this.checkBoxCustomOutputName.CheckedChanged += new System.EventHandler(this.checkBoxCustomOutputName_CheckedChanged);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(436, 177);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(188, 65);
            this.buttonConvert.TabIndex = 8;
            this.buttonConvert.Text = "Convertir";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 261);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(656, 22);
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel1.Text = "CSV";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 283);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonFindFile);
            this.Name = "MainForm";
            this.Text = "CSV a XLS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRecordsPerFile)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonFindFile;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFileDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCustomOutputName;
        private System.Windows.Forms.CheckBox checkBoxCustomOutputName;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRecordsPerFile;
        private System.Windows.Forms.CheckBox checkBoxFirstRowHasColumnNames;
        private System.Windows.Forms.TextBox textBoxDelimiter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxRemoveTextQualifier;
        private System.Windows.Forms.TextBox textBoxTextQualifier;
        private System.Windows.Forms.Label label7;
    }
}

