using System.Windows.Forms;

namespace Lab1_ChukarevMishail_6411
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.tabPage2 = new TabPage();
            this.tabPage3 = new TabPage();

            // Вкладка Шеннона-Фано
            this.groupBoxShannonFano = new GroupBox();
            this.labelFIO1 = new Label();
            this.txtFIO = new TextBox();
            this.labelCode1 = new Label();
            this.txtCode = new TextBox();
            this.btnEncode = new Button();
            this.labelOriginalSize1 = new Label();
            this.txtOriginalSize = new TextBox();
            this.labelEncodedSize1 = new Label();
            this.txtEncodedSize = new TextBox();
            this.labelCompression1 = new Label();
            this.txtCompression = new TextBox();
            this.labelProbabilities1 = new Label();
            this.txtProbabilities = new TextBox();

            // Вкладка Хаффмана
            this.groupBoxHuffman = new GroupBox();
            this.labelFIO2 = new Label();
            this.txtFIO2 = new TextBox();
            this.labelCode2 = new Label();
            this.txtCode2 = new TextBox();
            this.btnHuffmanEncode = new Button();
            this.labelOriginalSize2 = new Label();
            this.txtOriginalSize2 = new TextBox();
            this.labelEncodedSize2 = new Label();
            this.txtEncodedSize2 = new TextBox();
            this.labelCompression2 = new Label();
            this.txtCompression2 = new TextBox();
            this.labelProbabilities2 = new Label();
            this.txtProbabilities2 = new TextBox();

            // Вкладка Арифметическое
            this.groupBoxArithmetic = new GroupBox();
            this.labelFIO3 = new Label();
            this.txtFIO3 = new TextBox();
            this.labelCode3 = new Label();
            this.txtCode3 = new TextBox();
            this.btnAlgEncode = new Button();
            this.labelOriginalSize3 = new Label();
            this.txtOriginalSize3 = new TextBox();
            this.labelEncodedSize3 = new Label();
            this.txtEncodedSize3 = new TextBox();
            this.labelCompression3 = new Label();
            this.txtCompression3 = new TextBox();

            // Настройка tabControl1
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Size = new System.Drawing.Size(820, 500);
            this.tabControl1.SelectedIndex = 0;

            // Настройка вкладки 1: Шеннона-Фано
            this.tabPage1.Controls.Add(this.groupBoxShannonFano);
            this.tabPage1.Text = "Шеннона-Фано";

            // Группировка элементов для Шеннона-Фано
            this.groupBoxShannonFano.Controls.Add(this.labelFIO1);
            this.groupBoxShannonFano.Controls.Add(this.txtFIO);
            this.groupBoxShannonFano.Controls.Add(this.labelCode1);
            this.groupBoxShannonFano.Controls.Add(this.txtCode);
            this.groupBoxShannonFano.Controls.Add(this.btnEncode);
            this.groupBoxShannonFano.Controls.Add(this.labelOriginalSize1);
            this.groupBoxShannonFano.Controls.Add(this.txtOriginalSize);
            this.groupBoxShannonFano.Controls.Add(this.labelEncodedSize1);
            this.groupBoxShannonFano.Controls.Add(this.txtEncodedSize);
            this.groupBoxShannonFano.Controls.Add(this.labelCompression1);
            this.groupBoxShannonFano.Controls.Add(this.txtCompression);
            this.groupBoxShannonFano.Controls.Add(this.labelProbabilities1);
            this.groupBoxShannonFano.Controls.Add(this.txtProbabilities);
            this.groupBoxShannonFano.Location = new System.Drawing.Point(20, 20);
            this.groupBoxShannonFano.Size = new System.Drawing.Size(760, 430);
            this.groupBoxShannonFano.Text = "Алгоритм Шеннона-Фано";

            // Настройка элементов для вкладки 1
            this.labelFIO1.Text = "Введите ФИО:";
            this.labelFIO1.Location = new System.Drawing.Point(20, 30);

            this.txtFIO.Location = new System.Drawing.Point(150, 30);
            this.txtFIO.Size = new System.Drawing.Size(350, 22);

            this.labelCode1.Text = "Закодированная строка:";
            this.labelCode1.Location = new System.Drawing.Point(20, 70);

            this.txtCode.Location = new System.Drawing.Point(150, 70);
            this.txtCode.Size = new System.Drawing.Size(350, 22);

            this.btnEncode.Location = new System.Drawing.Point(550, 30);
            this.btnEncode.Size = new System.Drawing.Size(160, 30);
            this.btnEncode.Text = "Закодировать";
            this.btnEncode.Click += new System.EventHandler(this.BtnEncode_Click);

            this.labelOriginalSize1.Text = "Объем исходной строки:";
            this.labelOriginalSize1.Location = new System.Drawing.Point(20, 120);

            this.txtOriginalSize.Location = new System.Drawing.Point(220, 120);
            this.txtOriginalSize.Size = new System.Drawing.Size(100, 22);
            this.txtOriginalSize.ReadOnly = true;

            this.labelEncodedSize1.Text = "Объем закодированной строки:";
            this.labelEncodedSize1.Location = new System.Drawing.Point(20, 150);

            this.txtEncodedSize.Location = new System.Drawing.Point(220, 150);
            this.txtEncodedSize.Size = new System.Drawing.Size(100, 22);
            this.txtEncodedSize.ReadOnly = true;

            this.labelCompression1.Text = "Степень сжатия:";
            this.labelCompression1.Location = new System.Drawing.Point(20, 180);

            this.txtCompression.Location = new System.Drawing.Point(220, 180);
            this.txtCompression.Size = new System.Drawing.Size(100, 22);
            this.txtCompression.ReadOnly = true;

            this.labelProbabilities1.Text = "Вероятности символов:";
            this.labelProbabilities1.Location = new System.Drawing.Point(20, 210);

            this.txtProbabilities.Location = new System.Drawing.Point(20, 240);
            this.txtProbabilities.Size = new System.Drawing.Size(700, 160);
            this.txtProbabilities.Multiline = true;
            this.txtProbabilities.ReadOnly = true;

            // Настройка вкладки 2: Хаффмана
            this.tabPage2.Controls.Add(this.groupBoxHuffman);
            this.tabPage2.Text = "Хаффмана";

            // Группировка элементов для Хаффмана
            this.groupBoxHuffman.Controls.Add(this.labelFIO2);
            this.groupBoxHuffman.Controls.Add(this.txtFIO2);
            this.groupBoxHuffman.Controls.Add(this.labelCode2);
            this.groupBoxHuffman.Controls.Add(this.txtCode2);
            this.groupBoxHuffman.Controls.Add(this.btnHuffmanEncode);
            this.groupBoxHuffman.Controls.Add(this.labelOriginalSize2);
            this.groupBoxHuffman.Controls.Add(this.txtOriginalSize2);
            this.groupBoxHuffman.Controls.Add(this.labelEncodedSize2);
            this.groupBoxHuffman.Controls.Add(this.txtEncodedSize2);
            this.groupBoxHuffman.Controls.Add(this.labelCompression2);
            this.groupBoxHuffman.Controls.Add(this.txtCompression2);
            this.groupBoxHuffman.Controls.Add(this.labelProbabilities2);
            this.groupBoxHuffman.Controls.Add(this.txtProbabilities2);
            this.groupBoxHuffman.Location = new System.Drawing.Point(20, 20);
            this.groupBoxHuffman.Size = new System.Drawing.Size(760, 430);
            this.groupBoxHuffman.Text = "Алгоритм Хаффмана";

            // Настройка элементов для вкладки 2
            this.labelFIO2.Text = "Введите ФИО:";
            this.labelFIO2.Location = new System.Drawing.Point(20, 30);

            this.txtFIO2.Location = new System.Drawing.Point(150, 30);
            this.txtFIO2.Size = new System.Drawing.Size(350, 22);

            this.labelCode2.Text = "Закодированная строка:";
            this.labelCode2.Location = new System.Drawing.Point(20, 70);

            this.txtCode2.Location = new System.Drawing.Point(150, 70);
            this.txtCode2.Size = new System.Drawing.Size(350, 22);

            this.btnHuffmanEncode.Location = new System.Drawing.Point(550, 30);
            this.btnHuffmanEncode.Size = new System.Drawing.Size(160, 30);
            this.btnHuffmanEncode.Text = "Закодировать";
            this.btnHuffmanEncode.Click += new System.EventHandler(this.BtnHuffmanEncode_Click);

            this.labelOriginalSize2.Text = "Объем исходной строки:";
            this.labelOriginalSize2.Location = new System.Drawing.Point(20, 120);

            this.txtOriginalSize2.Location = new System.Drawing.Point(220, 120);
            this.txtOriginalSize2.Size = new System.Drawing.Size(100, 22);
            this.txtOriginalSize2.ReadOnly = true;

            this.labelEncodedSize2.Text = "Объем закодированной строки:";
            this.labelEncodedSize2.Location = new System.Drawing.Point(20, 150);

            this.txtEncodedSize2.Location = new System.Drawing.Point(220, 150);
            this.txtEncodedSize2.Size = new System.Drawing.Size(100, 22);
            this.txtEncodedSize2.ReadOnly = true;

            this.labelCompression2.Text = "Степень сжатия:";
            this.labelCompression2.Location = new System.Drawing.Point(20, 180);

            this.txtCompression2.Location = new System.Drawing.Point(220, 180);
            this.txtCompression2.Size = new System.Drawing.Size(100, 22);
            this.txtCompression2.ReadOnly = true;

            this.labelProbabilities2.Text = "Вероятности символов:";
            this.labelProbabilities2.Location = new System.Drawing.Point(20, 210);

            this.txtProbabilities2.Location = new System.Drawing.Point(20, 240);
            this.txtProbabilities2.Size = new System.Drawing.Size(700, 160);
            this.txtProbabilities2.Multiline = true;
            this.txtProbabilities2.ReadOnly = true;

            // Настройка вкладки 3: Арифметическое кодирование
            this.tabPage3.Controls.Add(this.groupBoxArithmetic);
            this.tabPage3.Text = "Арифметическое";

            // Группировка элементов для Арифметического кодирования
            this.groupBoxArithmetic.Controls.Add(this.labelFIO3);
            this.groupBoxArithmetic.Controls.Add(this.txtFIO3);
            this.groupBoxArithmetic.Controls.Add(this.labelCode3);
            this.groupBoxArithmetic.Controls.Add(this.txtCode3);
            this.groupBoxArithmetic.Controls.Add(this.btnAlgEncode);
            this.groupBoxArithmetic.Controls.Add(this.labelOriginalSize3);
            this.groupBoxArithmetic.Controls.Add(this.txtOriginalSize3);
            this.groupBoxArithmetic.Controls.Add(this.labelEncodedSize3);
            this.groupBoxArithmetic.Controls.Add(this.txtEncodedSize3);
            this.groupBoxArithmetic.Controls.Add(this.labelCompression3);
            this.groupBoxArithmetic.Controls.Add(this.txtCompression3);
            this.groupBoxArithmetic.Location = new System.Drawing.Point(20, 20);
            this.groupBoxArithmetic.Size = new System.Drawing.Size(760, 430);
            this.groupBoxArithmetic.Text = "Арифметический метод";

            // Настройка элементов для вкладки 3
            this.labelFIO3.Text = "Введите ФИО:";
            this.labelFIO3.Location = new System.Drawing.Point(20, 30);

            this.txtFIO3.Location = new System.Drawing.Point(150, 30);
            this.txtFIO3.Size = new System.Drawing.Size(350, 22);

            this.labelCode3.Text = "Закодированная строка:";
            this.labelCode3.Location = new System.Drawing.Point(20, 70);

            this.txtCode3.Location = new System.Drawing.Point(150, 70);
            this.txtCode3.Size = new System.Drawing.Size(350, 22);

            this.btnAlgEncode.Location = new System.Drawing.Point(550, 30);
            this.btnAlgEncode.Size = new System.Drawing.Size(160, 30);
            this.btnAlgEncode.Text = "Закодировать";
            this.btnAlgEncode.Click += new System.EventHandler(this.BtnAlgEncode_Click);

            this.labelOriginalSize3.Text = "Объем исходной строки:";
            this.labelOriginalSize3.Location = new System.Drawing.Point(20, 120);

            this.txtOriginalSize3.Location = new System.Drawing.Point(220, 120);
            this.txtOriginalSize3.Size = new System.Drawing.Size(100, 22);
            this.txtOriginalSize3.ReadOnly = true;

            this.labelEncodedSize3.Text = "Объем закодированной строки:";
            this.labelEncodedSize3.Location = new System.Drawing.Point(20, 150);

            this.txtEncodedSize3.Location = new System.Drawing.Point(220, 150);
            this.txtEncodedSize3.Size = new System.Drawing.Size(100, 22);
            this.txtEncodedSize3.ReadOnly = true;

            this.labelCompression3.Text = "Степень сжатия:";
            this.labelCompression3.Location = new System.Drawing.Point(20, 180);

            this.txtCompression3.Location = new System.Drawing.Point(220, 180);
            this.txtCompression3.Size = new System.Drawing.Size(100, 22);
            this.txtCompression3.ReadOnly = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(840, 520);
            this.Controls.Add(this.tabControl1);
            this.Text = "Приложение для кодирования";
            this.ResumeLayout(false);
        }

        #endregion

        // Компоненты
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBoxShannonFano;
        private GroupBox groupBoxHuffman;
        private GroupBox groupBoxArithmetic;

        // Элементы управления для вкладки Шеннона-Фано
        private Label labelFIO1, labelCode1, labelOriginalSize1, labelEncodedSize1, labelCompression1, labelProbabilities1;
        private TextBox txtFIO, txtCode, txtOriginalSize, txtEncodedSize, txtCompression, txtProbabilities;
        private Button btnEncode;

        // Элементы управления для вкладки Хаффмана
        private Label labelFIO2, labelCode2, labelOriginalSize2, labelEncodedSize2, labelCompression2, labelProbabilities2;
        private TextBox txtFIO2, txtCode2, txtOriginalSize2, txtEncodedSize2, txtCompression2, txtProbabilities2;
        private Button btnHuffmanEncode;

        // Элементы управления для вкладки Арифметического кодирования
        private Label labelFIO3, labelCode3, labelOriginalSize3, labelEncodedSize3, labelCompression3;
        private TextBox txtFIO3, txtCode3, txtOriginalSize3, txtEncodedSize3, txtCompression3;
        private Button btnAlgEncode;
    }
}

