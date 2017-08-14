using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVaXLS
{
    public partial class MainForm : Form
    {
        private long MAX_EXCEL_ROWS;
        private long fileTotalSizeInBytes = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFindFile_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                var fileInfo = new FileInfo(file);
                labelFileName.Text = fileInfo.Name; ;
                fileTotalSizeInBytes = fileInfo.Length;
                labelFileSize.Text = Helpers.HumanReadableSize(fileTotalSizeInBytes);
                labelFileDate.Text = fileInfo.LastWriteTime.ToString("dd/MM/yyyy HH:mm");
                if (!checkBoxCustomOutputName.Checked)
                {
                    textBoxCustomOutputName.Text = Path.GetFileNameWithoutExtension(fileInfo.Name);
                }
                textBoxFileName.Text = file;
                toolStripProgressBar1.Value = 0;
            }
        }

        private void UpdateStatusBar(string Text)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                toolStripStatusLabel1.Text = Text;
            }));
        }

        private void checkBoxCustomOutputName_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCustomOutputName.Enabled = checkBoxCustomOutputName.Checked;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            ReadFile();
            //int x = await ReadFileAsync();
        }

        #region ASYNCRONOUS METHODS
        private async Task<int> ReadFileAsync()
        {
            return await Task.Run(async () =>
            {
                var directoryPath = Path.GetDirectoryName(textBoxFileName.Text);
                var fileName = Path.GetFileNameWithoutExtension(labelFileName.Text);
                int outputFileCount = 1;
                long previousLength = 0;
                MAX_EXCEL_ROWS = (long)numericUpDownMaxRecordsPerFile.Value;
                IEnumerable<string> columns = null;
                List<string[]> lines = new List<string[]>();
                var delimiter = ',';
                if (!string.IsNullOrEmpty(textBoxDelimiter.Text))
                {
                    delimiter = textBoxDelimiter.Text[0];
                }
                var tasks = new List<Task<bool>>();
                using (var fs = File.OpenRead(textBoxFileName.Text))
                {
                    // position to just beyond where you read before
                    fs.Position = previousLength;

                    // and update the length for next time
                    previousLength = fs.Length;

                    // now open a StreamReader and read
                    using (var sr = new StreamReader(fs))
                    {
                        long lineCount = 1;
                        columns = sr.ReadLine().Split(delimiter);
                        while (!sr.EndOfStream)
                        {
                            lines.Add(sr.ReadLine().Split(delimiter));
                            lineCount++;

                            if ((lineCount % 1024 * 1024) == 0)
                            {
                                this.Invoke(new MethodInvoker(delegate
                                {
                                    var percentaje = (int)(fs.Position * 100 / fileTotalSizeInBytes);
                                    toolStripProgressBar1.Value = percentaje;
                                    UpdateStatusBar($"Leyendo {percentaje:00}%");
                                }));
                            }

                            //Trim the file size to MAX_EXCEL_ROWS
                            if ((lineCount % MAX_EXCEL_ROWS) == 0)
                            {
                                var thisFileName = $"{fileName} {outputFileCount:00}.xlsx";
                                var outputFileName = Path.Combine(directoryPath, thisFileName);
                                var result = await SaveExcelFileAsync(columns, lines, outputFileName);
                                if (!result)
                                {
                                    UpdateStatusBar($"Error en {thisFileName}.");
                                }
                                lines.Clear();
                                lineCount = 1;
                                outputFileCount++;
                            }
                        }
                        // Save the remaining lines
                        if (lineCount != 1)
                        {
                            var thisFileName = $"{fileName} {outputFileCount:00}.xlsx";
                            var outputFileName = Path.Combine(directoryPath, thisFileName);
                            var result = await SaveExcelFileAsync(columns, lines, outputFileName);
                            if (!result)
                            {
                                UpdateStatusBar($"Error en {thisFileName}.");
                            }
                            lines.Clear();
                            lineCount = 1;
                            outputFileCount++;
                        }
                    }
                }

                await Task.WhenAll(tasks);
                return 0;
            });
        }
        
        private async Task<bool> SaveExcelFileAsync(IEnumerable<string> columns, List<string[]> lines, string outputFileName)
        {
            return await Task.Run<bool>(() =>
            {
                var textQualifier = textBoxTextQualifier.Text;
                using (var dataSet = new DataSet())
                {
                    using (var dataTable = new DataTable())
                    {
                        int columnCount = 0;
                        foreach (var column in columns)
                        {
                            dataTable.Columns.Add(new DataColumn(column, typeof(string)));
                            columnCount++;
                        }
                        var progress = 0;
                        var totalLines = lines.Count();
                        //var progress = 0;
                        foreach (var data in lines)
                        {
                            DataRow row = dataTable.NewRow();
                            for (var i = 0; i < columnCount; i++)
                            {
                                if (checkBoxRemoveTextQualifier.Checked && !string.IsNullOrEmpty(textQualifier))
                                {
                                    row[columns.ElementAt(i)] = data[i].Replace(textQualifier, string.Empty);
                                }
                                else
                                {
                                    row[columns.ElementAt(i)] = data[i];
                                }
                            }
                            dataTable.Rows.Add(row);

                            this.Invoke(new MethodInvoker(delegate
                            {
                                var percentaje = (int)(++progress * 100 / totalLines);
                                toolStripProgressBar1.Value = percentaje;
                                UpdateStatusBar($"Exportando {percentaje:00}%");
                            }));
                        }


                        dataSet.Tables.Add(dataTable);
                        return ExportToExcel.CreateExcelFile.CreateExcelDocument(dataSet, outputFileName);
                    }
                }
            });
        }
        #endregion


        #region SYNCRONOUS METHODS
        private void ReadFile()
        {
            var directoryPath = Path.GetDirectoryName(textBoxFileName.Text);
            var fileName = Path.GetFileNameWithoutExtension(labelFileName.Text);
            int outputFileCount = 1;
            long previousLength = 0;
            MAX_EXCEL_ROWS = (long)numericUpDownMaxRecordsPerFile.Value;
            IEnumerable<string> columns = null;
            List<string[]> lines = new List<string[]>();
            var delimiter = ',';
            if (!string.IsNullOrEmpty(textBoxDelimiter.Text))
            {
                delimiter = textBoxDelimiter.Text[0];
            }

            using (var fs = File.OpenRead(textBoxFileName.Text))
            {
                // position to just beyond where you read before
                fs.Position = previousLength;

                // and update the length for next time
                previousLength = fs.Length;

                // now open a StreamReader and read
                using (var sr = new StreamReader(fs))
                {
                    long lineCount = 1;
                    columns = sr.ReadLine().Split(delimiter);
                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine().Split(delimiter));
                        lineCount++;

                        if ((lineCount % 1024 * 1024) == 0)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                var percentaje = (int)(fs.Position * 100 / fileTotalSizeInBytes);
                                toolStripProgressBar1.Value = percentaje;
                                UpdateStatusBar($"Leyendo {percentaje:00}%");
                            }));
                        }

                        //Trim the file size to MAX_EXCEL_ROWS
                        if ((lineCount % MAX_EXCEL_ROWS) == 0)
                        {
                            var thisFileName = $"{fileName} {outputFileCount:00}.xlsx";
                            var outputFileName = Path.Combine(directoryPath, thisFileName);
                            var result = SaveExcelFile(columns, lines, outputFileName);
                            if (!result)
                            {
                                UpdateStatusBar($"Error en {thisFileName}.");
                            }
                            lines.Clear();
                            lineCount = 1;
                            outputFileCount++;
                        }
                    }
                    // Save the remaining lines
                    if (lineCount != 1)
                    {
                        var thisFileName = $"{fileName} {outputFileCount:00}.xlsx";
                        var outputFileName = Path.Combine(directoryPath, thisFileName);
                        var result = SaveExcelFile(columns, lines, outputFileName);
                        if (!result)
                        {
                            UpdateStatusBar($"Error en {thisFileName}.");
                        }
                        lines.Clear();
                        lineCount = 1;
                        outputFileCount++;
                    }
                }
            }
        }
        private bool SaveExcelFile(IEnumerable<string> columns, List<string[]> lines, string outputFileName)
        {
            var textQualifier = textBoxTextQualifier.Text;
            using (var dataSet = new DataSet())
            {
                using (var dataTable = new DataTable())
                {
                    int columnCount = 0;
                    foreach (var column in columns)
                    {
                        dataTable.Columns.Add(new DataColumn(column, typeof(string)));
                        columnCount++;
                    }

                    var totalLines = lines.Count();
                    //var progress = 0;
                    foreach (var data in lines)
                    {
                        DataRow row = dataTable.NewRow();
                        for (var i = 0; i < columnCount; i++)
                        {
                            if (checkBoxRemoveTextQualifier.Checked && !string.IsNullOrEmpty(textQualifier))
                            {
                                row[columns.ElementAt(i)] = data[i].Replace(textQualifier, string.Empty);
                            }
                            else
                            {
                                row[columns.ElementAt(i)] = data[i];
                            }
                        }
                        dataTable.Rows.Add(row);
                        /*
                        this.Invoke(new MethodInvoker(delegate
                        {
                            var percentaje = (int)(++progress * 100 / totalLines);
                            toolStripProgressBar1.Value = percentaje;
                            UpdateStatusBar("Exportando");
                        }));
                        */
                    }


                    dataSet.Tables.Add(dataTable);
                    return ExportToExcel.CreateExcelFile.CreateExcelDocument(dataSet, outputFileName);
                }
            }
        }
        #endregion
    }
}
