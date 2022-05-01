using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
namespace NewNoteBlock {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            this.Text = Properties.Settings.Default.newDocName + " - " + Properties.Settings.Default.programmName;
        }
        public MainForm(string fileName) {// Открытие программы документом
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName)) {
                try {
                    string programmName = Properties.Settings.Default.programmName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    notebox.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + programmName;
                    notebox.Select(0, 0);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e) {
            //Задаем сохраненные (или стандартные) настройки
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            notebox.Font = Properties.Settings.Default.textFont;
            if (Properties.Settings.Default.statusStripVisible == true) {
                mViewStatusStrip.CheckState = CheckState.Checked;
            } else {
                mViewStatusStrip.CheckState = CheckState.Unchecked;
            } if (Properties.Settings.Default.textTransfer == true) {
                mFormatTransfer.CheckState = CheckState.Checked;
            } else {
            mFormatTransfer.CheckState = CheckState.Unchecked;
            }
        }
        bool tbChange = false; // Индикатор изменения текста
        string docPath = ""; // Переменная для хранения пути к файлу
        private void mFileNew_Click(object sender, EventArgs e) {// Создать новый документ
            if (tbChange == true) {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes) {
                    if (docPath != "") {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                    } else if (docPath == "") {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                } else if (message == DialogResult.No) {
                    FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
                }
            } else {
                FileWork.CreateFile(ref notebox, ref tbChange, ref docPath);
            }
        }
        private void mFileSaveAs_Click(object sender, EventArgs e) {// Сохранить документ КАК...
            FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
        }
        private void notebox_TextChanged(object sender, EventArgs e) {// При изменении текста в notebox
            tbChange = true; // Индикатор изменения текста
            TextWork.mEditEnableds(ref notebox, ref mEditCopy, ref mEditCut, ref mEditDel, ref mEditFind, ref mEditGo);
            TextWork.StatusAnalize(ref notebox, ref statusLinesCount , ref statusWordsCount, ref statusCharSpaceCount, ref statusCharCount);
        }
        private void mFileOpen_Click(object sender, EventArgs e) {// Открыть документ
            if (tbChange == true) {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes) {
                    if (docPath != "") {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    } else if (docPath == "") {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                } else if (message == DialogResult.No) {
                    FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
                } else {
                    return;
                }
            } else {
                FileWork.OpenFile(ref notebox, ref tbChange, ref docPath);
            }
        }
        private void mFileSave_Click(object sender, EventArgs e) {// Сохранить документ
            if (docPath != "") {
                FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
            } else {
                FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
            }
        }
        private void mFileExit_Click(object sender, EventArgs e) {// Выход из программы
            Application.Exit();
        }
        private void mFilePageParam_Click(object sender, EventArgs e) {// Параметры страницы печати
            if (pageSetupDialog.ShowDialog() == DialogResult.OK) {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }

        private void mFilePrint_Click(object sender, EventArgs e) {// Печать
            if (printDialog.ShowDialog() == DialogResult.OK) {
                try {
                    printDocument.Print();
                } catch (Exception) {
                    MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e) {// Отправка документа на печать
            e.Graphics.DrawString(notebox.Text, notebox.Font, Brushes.Black, 10, 10);
        }
        private void mEditCancel_Click(object sender, EventArgs e) {// Правка - ОТМЕНИТЬ
            notebox.Undo();
        }
        private void mEditCut_Click(object sender, EventArgs e) {// Правка - ВЫРЕЗАТЬ
            if (notebox.SelectionLength > 0) {
                notebox.Cut();
            }
        }
        private void mEditCopy_Click(object sender, EventArgs e) {// Правка - КОПИРОВАТЬ
            if (notebox.SelectionLength > 0) {
                notebox.Copy();
            }
        }
        private void mEditPaste_Click(object sender, EventArgs e) {// Правка - ВСТАВИТЬ
            notebox.Paste();
        }
        private void mEditDel_Click(object sender, EventArgs e) {// Правка - УДАЛИТЬ
            if (notebox.SelectionLength > 0) {
                notebox.SelectedText = "";
            }
        }
        private void mEditGiveAll_Click(object sender, EventArgs e) {// Правка - ВЫДЕЛИТЬ ВСЁ
            notebox.SelectAll();
        }
        private void mEditTime_Click(object sender, EventArgs e) {// Правка - ВРЕМЯ И ДАТА
            notebox.AppendText(Environment.NewLine + Convert.ToString(System.DateTime.Now));
        }
        private void mEditFind_Click(object sender, EventArgs e) {// ПОИСК и ЗАМЕНА текста
            SearchForm findText = new SearchForm();
            findText.Owner = this;
            findText.Show();
        }
        private void mHelpAboutProgram_Click(object sender, EventArgs e) {// Информация о программе
            AboutForm about = new AboutForm();
            about.Show();
        }
        private void mViewStatusStrip_CheckStateChanged(object sender, EventArgs e) {// Вид - СТРОКА СОСТОЯНИЯ
            if (mViewStatusStrip.CheckState == CheckState.Checked) {
                statusStrip.Visible = true;
            } else {
                statusStrip.Visible = false;
            }
        }
        private void mFormatTransfer_CheckStateChanged(object sender, EventArgs e) {// Формат - ПЕРЕНОС ПО СЛОВАМ
            if (mFormatTransfer.CheckState == CheckState.Checked) {
                notebox.WordWrap = true;
                notebox.ScrollBars = ScrollBars.Vertical;
                mEditGo.Enabled = false;
                statusLab1.Visible = false;
                statusLinesCount.Visible = false;
            } else {
                notebox.WordWrap = false;
                notebox.ScrollBars = ScrollBars.Both;
                mEditGo.Enabled = true;
                statusLab1.Visible = true;
                statusLinesCount.Visible = true;
            }
        }
        private void mEditGo_Click(object sender, EventArgs e) {// Правка - ПЕРЕЙТИ
            GoToForm gotoform = new GoToForm();
            gotoform.Owner = this;
            gotoform.tbLineNum.Minimum = 0;
            gotoform.tbLineNum.Maximum = notebox.Lines.Count();
            gotoform.ShowDialog();
        }
        private void mFormatFont_Click(object sender, EventArgs e) {// Формат - ШРИФТ
            fontDialog.Font = notebox.Font;
            DialogResult = fontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK) {
                notebox.Font = fontDialog.Font;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {// Событие ДО выхода из программы
            Properties.Settings.Default.formWidth = this.Width;
            Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textTransfer = notebox.WordWrap;
            Properties.Settings.Default.textFont = notebox.Font;
            Properties.Settings.Default.statusStripVisible = statusStrip.Visible;
            Properties.Settings.Default.Save();
            if (tbChange == true) {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes) {
                    if (docPath != "") {
                        FileWork.SaveFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    } else if (docPath == "") {
                        FileWork.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                } else if (message == DialogResult.Cancel) {
                    e.Cancel = true;
                }
            }
        }
    }
}